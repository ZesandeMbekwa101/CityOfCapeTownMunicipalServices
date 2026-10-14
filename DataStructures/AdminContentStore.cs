using System;
using System.Collections.Generic;
using System.Linq;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.DataStructures
{
    public static class AdminContentStore
    {
        // Set this ONCE to your real IssueStore.GetAll... method. No fake requests.
        // Return the original IssueReport objects, not copied projections.
        public static Func<IEnumerable<IssueReport>> LoadIssueReports;
        private static readonly Dictionary<string, string> notes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public static IEnumerable<AdminRequest> GetRequests()
        {
            IEnumerable<IssueReport> reports = LoadIssueReports == null ?
                Enumerable.Empty<IssueReport>() : (LoadIssueReports() ?? Enumerable.Empty<IssueReport>());
            return reports.Where(x => x != null).Select(x => new AdminRequest
            {
                Reference = x.ReferenceNumber,
                Resident = x.UserEmail,
                Category = x.Category,
                Description = x.Description,
                Location = x.Location,
                Status = string.IsNullOrWhiteSpace(x.Status) ? "Pending" : x.Status,
                Submitted = x.DateReported,
                AdminNotes = GetNote(x.ReferenceNumber)
            }).ToList();
        }

        private static string GetNote(string reference)
        {
            string value;
            return reference != null && notes.TryGetValue(reference, out value) ? value : "";
        }

        public static bool UpdateRequest(AdminRequest request, string status, string adminNotes)
        {
            if (LoadIssueReports == null || request == null) return false;
            IssueReport original = (LoadIssueReports() ?? Enumerable.Empty<IssueReport>())
                .FirstOrDefault(x => x != null && string.Equals(x.ReferenceNumber, request.Reference, StringComparison.OrdinalIgnoreCase));
            if (original == null) return false;
            original.Status = status; // Updates the original object in the in-memory store.
            notes[original.ReferenceNumber] = adminNotes ?? "";
            return true;
        }

        public static IEnumerable<AdminContent> GetContent(string kind)
        {
            bool announcement = kind == "Announcement";
            return EventStore.GetAllEvents().Where(x => x.IsAnnouncement == announcement)
                .Select(x => new AdminContent
                {
                    Id = x.EventId,
                    Kind = kind,
                    Title = x.Title,
                    Category = x.Category,
                    Description = x.Description,
                    Location = x.Location,
                    Date = x.EventDate,
                    EndDate = x.EndDate,
                    Status = x.EventDate < DateTime.Now ? "Completed" : "Upcoming"
                }).ToList();
        }

        public static bool SaveContent(AdminContent item)
        {
            if (item == null) return false;
            MunicipalEvent record = new MunicipalEvent
            {
                EventId = item.Id == 0 ? EventStore.GetNextEventId() : item.Id,
                Title = item.Title,
                Category = item.Category,
                Description = item.Description,
                Location = item.Location,
                EventDate = item.Date,
                EndDate = item.EndDate <= item.Date ? item.Date.AddHours(1) : item.EndDate,
                IsAnnouncement = item.Kind == "Announcement"
            };
            return item.Id == 0 ? EventStore.AddEvent(record) : EventStore.UpdateEvent(record);
        }

        public static bool DeleteContent(AdminContent item)
        {
            return item != null && EventStore.DeleteEvent(item.Id);
        }
    }
}
