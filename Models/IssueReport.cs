using System;

namespace CityOfCapeTownMunicipalServices.Models
{
    public class IssueReport
    {
        public string ReferenceNumber
        {
            get;
            set;
        }

        public string UserEmail
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string AttachmentPath
        {
            get;
            set;
        }

        public DateTime DateReported
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }
    }
}