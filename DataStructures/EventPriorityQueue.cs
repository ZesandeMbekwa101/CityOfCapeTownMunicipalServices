using System.Collections.Generic;

using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.DataStructures
{
    public class EventPriorityQueue
    {
        private readonly
            SortedDictionary<int, Queue<MunicipalEvent>>
            priorityItems;


        public EventPriorityQueue()
        {
            priorityItems =
                new SortedDictionary
                    <int, Queue<MunicipalEvent>>();
        }


        public int Count { get; private set; }


        // =====================================================
        // ENQUEUE
        //
        // Lower number = higher priority.
        //
        // Example:
        // Priority 10 comes before Priority 50.
        // =====================================================

        public void Enqueue(
            MunicipalEvent municipalEvent,
            int priority)
        {
            if (municipalEvent == null)
            {
                return;
            }


            if (!priorityItems.ContainsKey(
                priority))
            {
                priorityItems[priority] =
                    new Queue<MunicipalEvent>();
            }


            priorityItems[
                priority].Enqueue(
                    municipalEvent);


            Count++;
        }


        // =====================================================
        // DEQUEUE
        // =====================================================

        public MunicipalEvent Dequeue()
        {
            if (Count == 0)
            {
                return null;
            }


            int selectedPriority = 0;

            bool found =
                false;


            foreach (
                KeyValuePair
                    <int, Queue<MunicipalEvent>>
                    pair
                in priorityItems)
            {
                if (pair.Value.Count > 0)
                {
                    selectedPriority =
                        pair.Key;

                    found =
                        true;

                    break;
                }
            }


            if (!found)
            {
                return null;
            }


            MunicipalEvent municipalEvent =
                priorityItems[
                    selectedPriority]
                .Dequeue();


            if (
                priorityItems[
                    selectedPriority]
                .Count == 0)
            {
                priorityItems.Remove(
                    selectedPriority);
            }


            Count--;


            return municipalEvent;
        }


        // =====================================================
        // CLEAR
        // =====================================================

        public void Clear()
        {
            priorityItems.Clear();

            Count = 0;
        }
    }
}