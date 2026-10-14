using System;

namespace CityOfCapeTownMunicipalServices.Models
{
    public class MunicipalEvent
    {
        public int EventId { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime EventDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsAnnouncement { get; set; }


        public string DisplayType
        {
            get
            {
                return IsAnnouncement
                    ? "Announcement"
                    : "Event";
            }
        }
    }
}