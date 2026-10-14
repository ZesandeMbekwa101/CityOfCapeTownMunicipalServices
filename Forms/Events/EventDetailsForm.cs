using System;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;

namespace CityOfCapeTownMunicipalServices.Forms.Events
{
    public partial class EventDetailsForm : Form
    {
        private readonly EventService eventService;

        private readonly int eventId;


        public EventDetailsForm(
            int selectedEventId)
        {
            InitializeComponent();


            eventService =
                new EventService();


            eventId =
                selectedEventId;


            LoadEvent();
        }


        // =====================================================
        // LOAD EVENT
        // =====================================================

        private void LoadEvent()
        {
            MunicipalEvent municipalEvent =
                eventService.GetEventById(
                    eventId);


            if (municipalEvent == null)
            {
                MessageBox.Show(
                    "The selected event could not be found.",
                    "Event Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();

                return;
            }


            // Record interest for recommendations
            eventService.RecordEventView(
                eventId);


            lblEventTitle.Text =
                municipalEvent.Title;


            lblCategory.Text =
                municipalEvent.Category;


            lblDate.Text =
                "▣  " +
                municipalEvent.EventDate
                    .ToString(
                        "dddd, dd MMMM yyyy");


            lblTime.Text =
                "◷  " +
                municipalEvent.EventDate
                    .ToString("HH:mm") +
                " - " +
                municipalEvent.EndDate
                    .ToString("HH:mm");


            lblLocation.Text =
                "●  " +
                municipalEvent.Location;


            lblDescription.Text =
                municipalEvent.Description;


            lblHeroText.Text =
                municipalEvent.IsAnnouncement
                    ? "CITY OF CAPE TOWN\nMUNICIPAL ANNOUNCEMENT"
                    : "CITY OF CAPE TOWN\nCOMMUNITY EVENT";
        }


        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}