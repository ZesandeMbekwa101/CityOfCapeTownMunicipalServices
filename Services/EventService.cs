using System;
using System.Collections.Generic;
using System.Linq;

using CityOfCapeTownMunicipalServices.DataStructures;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.Services
{
    public class EventService
    {
        // =====================================================
        // UPCOMING EVENTS
        // =====================================================

        public List<MunicipalEvent>
            GetUpcomingEvents()
        {
            return EventStore
                .GetAllEvents()
                .Where(
                    municipalEvent =>
                        municipalEvent.EventDate >=
                        DateTime.Today)
                .OrderBy(
                    municipalEvent =>
                        municipalEvent.EventDate)
                .ToList();
        }


        // =====================================================
        // EVENT BY ID
        // =====================================================

        public MunicipalEvent GetEventById(
            int eventId)
        {
            return EventStore.GetEventById(
                eventId);
        }


        // =====================================================
        // CATEGORIES
        // =====================================================

        public List<string> GetCategories()
        {
            return EventStore.GetCategories();
        }


        // =====================================================
        // SEARCH
        // =====================================================

        public List<MunicipalEvent>
            SearchEvents(
                string searchText,
                string category,
                DateTime? selectedDate)
        {
            IEnumerable<MunicipalEvent> query =
                GetUpcomingEvents();


            // =================================================
            // TEXT SEARCH
            // =================================================

            if (!string.IsNullOrWhiteSpace(
                searchText))
            {
                string search =
                    searchText
                        .Trim()
                        .ToLower();


                query =
                    query.Where(
                        municipalEvent =>

                            ContainsText(
                                municipalEvent.Title,
                                search)

                            ||

                            ContainsText(
                                municipalEvent.Description,
                                search)

                            ||

                            ContainsText(
                                municipalEvent.Location,
                                search)

                            ||

                            ContainsText(
                                municipalEvent.Category,
                                search));
            }


            // =================================================
            // CATEGORY FILTER
            // =================================================

            if (
                !string.IsNullOrWhiteSpace(
                    category)
                &&
                !category.Equals(
                    "All",
                    StringComparison.OrdinalIgnoreCase)
                &&
                !category.Equals(
                    "All Categories",
                    StringComparison.OrdinalIgnoreCase))
            {
                query =
                    query.Where(
                        municipalEvent =>
                            string.Equals(
                                municipalEvent.Category,
                                category,
                                StringComparison.OrdinalIgnoreCase));
            }


            // =================================================
            // DATE FILTER
            // =================================================

            if (selectedDate.HasValue)
            {
                query =
                    query.Where(
                        municipalEvent =>
                            municipalEvent
                                .EventDate
                                .Date ==
                            selectedDate
                                .Value
                                .Date);
            }


            List<MunicipalEvent> results =
                query
                    .OrderBy(
                        municipalEvent =>
                            municipalEvent.EventDate)
                    .ToList();


            // =================================================
            // RECORD ACTUAL USER SEARCH
            // =================================================

            if (!string.IsNullOrWhiteSpace(
                searchText))
            {
                EventStore.RecordSearchText(
                    searchText);
            }


            // =================================================
            // SELECTED CATEGORY ALSO SHOWS INTEREST
            // =================================================

            if (
                !string.IsNullOrWhiteSpace(
                    category)
                &&
                !category.Equals(
                    "All",
                    StringComparison.OrdinalIgnoreCase)
                &&
                !category.Equals(
                    "All Categories",
                    StringComparison.OrdinalIgnoreCase))
            {
                EventStore.RecordCategoryInterest(
                    category);
            }


            // =================================================
            // LEARN FROM ACTUAL SEARCH RESULTS
            //
            // Example:
            //
            // Search = "career"
            //
            // Result =
            // Youth Career Development Workshop
            //
            // Category =
            // Education
            //
            // Therefore Education gets recommendation interest.
            // =================================================

            if (
                !string.IsNullOrWhiteSpace(
                    searchText)
                &&
                results.Count > 0)
            {
                List<string> matchedCategories =
                    results
                        .Where(
                            municipalEvent =>
                                !string.IsNullOrWhiteSpace(
                                    municipalEvent.Category))
                        .Select(
                            municipalEvent =>
                                municipalEvent.Category)
                        .Distinct(
                            StringComparer.OrdinalIgnoreCase)
                        .ToList();


                foreach (
                    string matchedCategory
                    in matchedCategories)
                {
                    EventStore.RecordCategoryInterest(
                        matchedCategory);
                }
            }


            return results;
        }


        // =====================================================
        // RECORD EVENT VIEW
        // =====================================================

        public void RecordEventView(
            int eventId)
        {
            MunicipalEvent municipalEvent =
                EventStore.GetEventById(
                    eventId);


            if (municipalEvent == null)
            {
                return;
            }


            EventStore.RecordEventInterest(
                municipalEvent);
        }


        // =====================================================
        // RECOMMENDATIONS
        // =====================================================

        public List<MunicipalEvent>
            GetRecommendations(
                int maximumResults)
        {
            List<MunicipalEvent> upcoming =
                GetUpcomingEvents();


            EventPriorityQueue priorityQueue =
                new EventPriorityQueue();


            foreach (
                MunicipalEvent municipalEvent
                in upcoming)
            {
                int interestCount =
                    EventStore
                        .GetCategorySearchCount(
                            municipalEvent.Category);


                // Higher interest means lower priority number.
                int preferencePriority =
                    100 -
                    Math.Min(
                        interestCount * 15,
                        90);


                int daysAway =
                    Math.Max(
                        0,
                        (
                            municipalEvent
                                .EventDate
                                .Date
                            -
                            DateTime.Today
                        ).Days);


                int datePriority =
                    Math.Min(
                        daysAway,
                        30);


                int finalPriority =
                    preferencePriority +
                    datePriority;


                priorityQueue.Enqueue(
                    municipalEvent,
                    finalPriority);
            }


            List<MunicipalEvent> recommendations =
                new List<MunicipalEvent>();


            while (
                priorityQueue.Count > 0
                &&
                recommendations.Count <
                maximumResults)
            {
                MunicipalEvent next =
                    priorityQueue.Dequeue();


                if (next != null)
                {
                    recommendations.Add(
                        next);
                }
            }


            return recommendations;
        }


        // =====================================================
        // PREFERRED CATEGORY
        // =====================================================

        public string GetPreferredCategory()
        {
            return EventStore
                .GetMostSearchedCategory();
        }


        // =====================================================
        // SEARCH HISTORY
        // =====================================================

        public List<string> GetSearchHistory()
        {
            return EventStore
                .GetSearchHistory();
        }


        // =====================================================
        // HELPER
        // =====================================================

        private bool ContainsText(
            string value,
            string search)
        {
            if (string.IsNullOrWhiteSpace(
                value))
            {
                return false;
            }


            return value
                .ToLower()
                .Contains(search);
        }
    }
}