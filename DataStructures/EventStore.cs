using System;
using System.Collections.Generic;
using System.Linq;

using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.DataStructures
{
    public static class EventStore
    {
        // =====================================================
        // SORTED DICTIONARY
        // Events organised by date.
        // =====================================================

        private static readonly
            SortedDictionary<DateTime, List<MunicipalEvent>>
            eventsByDate =
                new SortedDictionary
                    <DateTime, List<MunicipalEvent>>();


        // =====================================================
        // DICTIONARY
        // Fast lookup by event ID.
        // =====================================================

        private static readonly
            Dictionary<int, MunicipalEvent>
            eventsById =
                new Dictionary<int, MunicipalEvent>();


        // =====================================================
        // HASH SET
        // Unique categories.
        // =====================================================

        private static readonly
            HashSet<string>
            categories =
                new HashSet<string>(
                    StringComparer.OrdinalIgnoreCase);


        // =====================================================
        // STACK
        // Stores actual text searches.
        // =====================================================

        private static readonly
            Stack<string>
            searchHistory =
                new Stack<string>();


        // =====================================================
        // QUEUE
        // Stores recent category interests.
        // =====================================================

        private static readonly
            Queue<string>
            recentCategorySearches =
                new Queue<string>();


        // =====================================================
        // DICTIONARY
        // Category -> interest count.
        // =====================================================

        private static readonly
            Dictionary<string, int>
            categorySearchFrequency =
                new Dictionary<string, int>(
                    StringComparer.OrdinalIgnoreCase);


        // =====================================================
        // STATIC CONSTRUCTOR
        // =====================================================




        // =====================================================
        // ADD EVENT
        // =====================================================

        public static bool AddEvent(
            MunicipalEvent municipalEvent)
        {
            if (municipalEvent == null)
            {
                return false;
            }


            if (eventsById.ContainsKey(
                municipalEvent.EventId))
            {
                return false;
            }


            eventsById.Add(
                municipalEvent.EventId,
                municipalEvent);


            if (!string.IsNullOrWhiteSpace(
                municipalEvent.Category))
            {
                categories.Add(
                    municipalEvent.Category);
            }


            DateTime date =
                municipalEvent
                    .EventDate
                    .Date;


            if (!eventsByDate.ContainsKey(
                date))
            {
                eventsByDate.Add(
                    date,
                    new List<MunicipalEvent>());
            }


            eventsByDate[
                date].Add(
                    municipalEvent);


            return true;
        }


        // =====================================================
        // GET ALL EVENTS
        // =====================================================

        public static List<MunicipalEvent>
            GetAllEvents()
        {
            return eventsByDate
                .SelectMany(
                    pair =>
                        pair.Value)
                .OrderBy(
                    municipalEvent =>
                        municipalEvent.EventDate)
                .ToList();
        }


        // =====================================================
        // GET EVENT BY ID
        // =====================================================

        public static MunicipalEvent
            GetEventById(
                int eventId)
        {
            MunicipalEvent municipalEvent;


            if (eventsById.TryGetValue(
                eventId,
                out municipalEvent))
            {
                return municipalEvent;
            }


            return null;
        }


        // =====================================================
        // GET CATEGORIES
        // =====================================================

        public static List<string>
            GetCategories()
        {
            return categories
                .OrderBy(
                    category =>
                        category)
                .ToList();
        }


        // =====================================================
        // RECORD THE ACTUAL TEXT USER SEARCHED
        //
        // Example:
        // "career"
        // "recycling"
        // "health"
        // =====================================================

        public static void RecordSearchText(
            string searchText)
        {
            if (string.IsNullOrWhiteSpace(
                searchText))
            {
                return;
            }


            searchHistory.Push(
                searchText.Trim());
        }


        // =====================================================
        // RECORD CATEGORY INTEREST
        //
        // This is called when:
        // - search results match a category
        // - user selects a category
        // - user views an event
        // =====================================================

        public static void RecordCategoryInterest(
            string category)
        {
            if (string.IsNullOrWhiteSpace(
                category))
            {
                return;
            }


            if (
                category.Equals(
                    "All",
                    StringComparison.OrdinalIgnoreCase)
                ||
                category.Equals(
                    "All Categories",
                    StringComparison.OrdinalIgnoreCase))
            {
                return;
            }


            // QUEUE

            recentCategorySearches.Enqueue(
                category);


            while (
                recentCategorySearches.Count > 5)
            {
                recentCategorySearches.Dequeue();
            }


            // DICTIONARY

            if (!categorySearchFrequency
                .ContainsKey(category))
            {
                categorySearchFrequency[
                    category] = 0;
            }


            categorySearchFrequency[
                category]++;
        }


        // =====================================================
        // RECORD SEARCH
        // Compatibility method.
        // =====================================================

        public static void RecordSearch(
            string searchText,
            string category)
        {
            RecordSearchText(
                searchText);


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
                RecordCategoryInterest(
                    category);
            }
        }


        // =====================================================
        // RECORD EVENT VIEW
        // =====================================================

        public static void RecordEventInterest(
            MunicipalEvent municipalEvent)
        {
            if (
                municipalEvent == null
                ||
                string.IsNullOrWhiteSpace(
                    municipalEvent.Category))
            {
                return;
            }


            RecordCategoryInterest(
                municipalEvent.Category);
        }


        // =====================================================
        // GET CATEGORY INTEREST COUNT
        // =====================================================

        public static int GetCategorySearchCount(
            string category)
        {
            if (string.IsNullOrWhiteSpace(
                category))
            {
                return 0;
            }


            int count;


            if (categorySearchFrequency
                .TryGetValue(
                    category,
                    out count))
            {
                return count;
            }


            return 0;
        }


        // =====================================================
        // MOST SEARCHED CATEGORY
        // =====================================================

        public static string
            GetMostSearchedCategory()
        {
            if (
                categorySearchFrequency.Count ==
                0)
            {
                return null;
            }


            return categorySearchFrequency
                .OrderByDescending(
                    pair =>
                        pair.Value)
                .ThenBy(
                    pair =>
                        pair.Key)
                .First()
                .Key;
        }


        // =====================================================
        // SEARCH HISTORY
        // =====================================================

        public static List<string>
            GetSearchHistory()
        {
            return searchHistory
                .ToList();
        }


        // =====================================================
        // RECENT CATEGORY SEARCHES
        // =====================================================

        public static List<string>
            GetRecentCategorySearches()
        {
            return recentCategorySearches
                .ToList();
        }



        // Admin operations: preserve both the ID and date indexes.
        public static int GetNextEventId()
        {
            return eventsById.Count == 0 ? 1 : eventsById.Keys.Max() + 1;
        }

        public static bool UpdateEvent(MunicipalEvent changed)
        {
            if (changed == null || !eventsById.ContainsKey(changed.EventId)) return false;
            MunicipalEvent current = eventsById[changed.EventId];
            DateTime oldDate = current.EventDate.Date;
            DateTime newDate = changed.EventDate.Date;
            if (oldDate != newDate)
            {
                eventsByDate[oldDate].Remove(current);
                if (eventsByDate[oldDate].Count == 0) eventsByDate.Remove(oldDate);
                if (!eventsByDate.ContainsKey(newDate))
                    eventsByDate[newDate] = new List<MunicipalEvent>();
                eventsByDate[newDate].Add(current);
            }
            current.Title = changed.Title;
            current.Category = changed.Category;
            current.Description = changed.Description;
            current.Location = changed.Location;
            current.EventDate = changed.EventDate;
            current.EndDate = changed.EndDate;
            current.IsAnnouncement = changed.IsAnnouncement;
            categories.Clear();
            foreach (MunicipalEvent item in eventsById.Values)
                if (!string.IsNullOrWhiteSpace(item.Category)) categories.Add(item.Category);
            return true;
        }

        public static bool DeleteEvent(int id)
        {
            MunicipalEvent current;
            if (!eventsById.TryGetValue(id, out current)) return false;
            eventsById.Remove(id);
            DateTime date = current.EventDate.Date;
            eventsByDate[date].Remove(current);
            if (eventsByDate[date].Count == 0) eventsByDate.Remove(date);
            categories.Clear();
            foreach (MunicipalEvent item in eventsById.Values)
                if (!string.IsNullOrWhiteSpace(item.Category)) categories.Add(item.Category);
            return true;
        }

    }
}
