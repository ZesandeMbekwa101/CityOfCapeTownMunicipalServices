using System;
namespace CityOfCapeTownMunicipalServices.Models
{
    public class AdminRequest
    {
        public string Reference { get; set; }
        public string Resident { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string AdminNotes { get; set; }
        public DateTime Submitted { get; set; }
    }
    public class AdminContent
    {
        public int Id { get; set; } // 0 means new record
        public string Kind { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; } = DateTime.Today.AddDays(1);
        public DateTime EndDate { get; set; } = DateTime.Today.AddDays(1).AddHours(1);
        public string Status { get; set; }
    }
}
