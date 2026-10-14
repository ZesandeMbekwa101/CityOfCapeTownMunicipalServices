using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;

namespace CityOfCapeTownMunicipalServices.Forms.Events
{
    public partial class LocalEventsForm : Form
    {
        private readonly EventService
            eventService;

        private string
            selectedCategory;


        public LocalEventsForm()
        {
            InitializeComponent();


            eventService =
                new EventService();


            selectedCategory =
                "All";


            SetSelectedCategory(
                btnAll);


            LoadEvents();
        }


        // =====================================================
        // LOAD UPCOMING EVENTS
        //
        // IMPORTANT:
        // Simply loading the page does NOT count as a search.
        // =====================================================

        private void LoadEvents()
        {
            List<MunicipalEvent> events;


            if (selectedCategory == "All")
            {
                events =
                    eventService
                        .GetUpcomingEvents();
            }
            else
            {
                events =
                    eventService
                        .GetUpcomingEvents()
                        .FindAll(
                            municipalEvent =>
                                string.Equals(
                                    municipalEvent.Category,
                                    selectedCategory,
                                    StringComparison.OrdinalIgnoreCase));
            }


            DisplayEvents(
                events);
        }


        // =====================================================
        // DISPLAY EVENTS
        // =====================================================

        private void DisplayEvents(
            List<MunicipalEvent> events)
        {
            pnlEvents.Controls.Clear();


            if (
                events == null ||
                events.Count == 0)
            {
                Label empty =
                    new Label();


                empty.Text =
                    "No upcoming events were found.";

                empty.Size =
                    new Size(
                        800,
                        80);

                empty.TextAlign =
                    ContentAlignment.MiddleCenter;

                empty.Font =
                    new Font(
                        "Segoe UI",
                        11F,
                        FontStyle.Bold);

                empty.ForeColor =
                    Color.Gray;


                pnlEvents.Controls.Add(
                    empty);


                return;
            }


            foreach (
                MunicipalEvent municipalEvent
                in events)
            {
                pnlEvents.Controls.Add(
                    CreateEventCard(
                        municipalEvent));
            }
        }


        // =====================================================
        // EVENT CARD
        // =====================================================

        private Panel CreateEventCard(
            MunicipalEvent municipalEvent)
        {
            Panel card =
                new Panel();


            card.Size =
                new Size(
                    455,
                    245);

            card.Margin =
                new Padding(
                    0,
                    0,
                    20,
                    20);

            card.BackColor =
                Color.White;

            card.BorderStyle =
                BorderStyle.FixedSingle;


            // =================================================
            // DATE
            // =================================================

            Label lblDate =
                new Label();


            lblDate.Text =
                municipalEvent
                    .EventDate
                    .ToString(
                        "dd\nMMM")
                    .ToUpper();

            lblDate.Location =
                new Point(
                    15,
                    20);

            lblDate.Size =
                new Size(
                    65,
                    65);

            lblDate.TextAlign =
                ContentAlignment.MiddleCenter;

            lblDate.Font =
                new Font(
                    "Segoe UI",
                    13F,
                    FontStyle.Bold);

            lblDate.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            // =================================================
            // TITLE
            // =================================================

            Label lblTitle =
                new Label();


            lblTitle.Text =
                municipalEvent.Title;

            lblTitle.Location =
                new Point(
                    95,
                    18);

            lblTitle.Size =
                new Size(
                    330,
                    45);

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            // =================================================
            // CATEGORY
            // =================================================

            Label lblCategory =
                new Label();


            lblCategory.Text =
                municipalEvent.Category;

            lblCategory.Location =
                new Point(
                    95,
                    68);

            lblCategory.Size =
                new Size(
                    180,
                    25);

            lblCategory.ForeColor =
                Color.FromArgb(
                    0,
                    119,
                    200);


            // =================================================
            // TIME
            // =================================================

            Label lblTime =
                new Label();


            lblTime.Text =
                "Time: " +
                municipalEvent
                    .EventDate
                    .ToString("HH:mm") +
                " - " +
                municipalEvent
                    .EndDate
                    .ToString("HH:mm");

            lblTime.Location =
                new Point(
                    95,
                    100);

            lblTime.Size =
                new Size(
                    300,
                    25);


            // =================================================
            // LOCATION
            // =================================================

            Label lblLocation =
                new Label();


            lblLocation.Text =
                "Location: " +
                municipalEvent.Location;

            lblLocation.Location =
                new Point(
                    95,
                    128);

            lblLocation.Size =
                new Size(
                    330,
                    25);


            // =================================================
            // DESCRIPTION
            // =================================================

            Label lblDescription =
                new Label();


            string description =
                municipalEvent.Description;


            if (
                !string.IsNullOrWhiteSpace(
                    description)
                &&
                description.Length > 80)
            {
                description =
                    description.Substring(
                        0,
                        80)
                    +
                    "...";
            }


            lblDescription.Text =
                description;

            lblDescription.Location =
                new Point(
                    95,
                    158);

            lblDescription.Size =
                new Size(
                    330,
                    40);

            lblDescription.ForeColor =
                Color.Gray;


            // =================================================
            // VIEW DETAILS
            // =================================================

            Button btnDetails =
                new Button();


            btnDetails.Text =
                "View Details";

            btnDetails.Location =
                new Point(
                    305,
                    200);

            btnDetails.Size =
                new Size(
                    120,
                    35);

            btnDetails.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            btnDetails.ForeColor =
                Color.White;

            btnDetails.FlatStyle =
                FlatStyle.Flat;

            btnDetails.FlatAppearance.BorderSize =
                0;

            btnDetails.Cursor =
                Cursors.Hand;

            btnDetails.Tag =
                municipalEvent.EventId;

            btnDetails.Click +=
                btnViewDetails_Click;


            card.Controls.Add(
                lblDate);

            card.Controls.Add(
                lblTitle);

            card.Controls.Add(
                lblCategory);

            card.Controls.Add(
                lblTime);

            card.Controls.Add(
                lblLocation);

            card.Controls.Add(
                lblDescription);

            card.Controls.Add(
                btnDetails);


            return card;
        }


        // =====================================================
        // VIEW DETAILS
        // =====================================================

        private void btnViewDetails_Click(
            object sender,
            EventArgs e)
        {
            Button button =
                sender as Button;


            if (button == null)
            {
                return;
            }


            int eventId =
                Convert.ToInt32(
                    button.Tag);


            using (
                EventDetailsForm detailsForm =
                    new EventDetailsForm(
                        eventId))
            {
                detailsForm.ShowDialog(
                    this);
            }
        }


        // =====================================================
        // SEARCH
        // =====================================================

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            string searchText =
                txtSearch.Text.Trim();


            // Prevent completely empty search when All selected.
            if (
                string.IsNullOrWhiteSpace(
                    searchText)
                &&
                selectedCategory == "All")
            {
                MessageBox.Show(
                    "Please enter something to search for or select a category.",
                    "Search Events",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtSearch.Focus();

                return;
            }


            List<MunicipalEvent> results =
                eventService.SearchEvents(
                    searchText,
                    selectedCategory,
                    null);


            using (
                SearchResultsForm searchForm =
                    new SearchResultsForm(
                        searchText,
                        selectedCategory,
                        results))
            {
                searchForm.ShowDialog(
                    this);
            }
        }


        // =====================================================
        // RECOMMENDED
        // =====================================================

        private void btnRecommended_Click(
            object sender,
            EventArgs e)
        {
            using (
                RecommendedEventsForm form =
                    new RecommendedEventsForm())
            {
                form.ShowDialog(
                    this);
            }
        }


        // =====================================================
        // CATEGORY BUTTONS
        // =====================================================

        private void btnAll_Click(
            object sender,
            EventArgs e)
        {
            SelectCategory(
                "All",
                btnAll);
        }


        private void btnCommunity_Click(
            object sender,
            EventArgs e)
        {
            SelectCategory(
                "Community",
                btnCommunity);
        }


        private void btnEnvironment_Click(
            object sender,
            EventArgs e)
        {
            SelectCategory(
                "Environment",
                btnEnvironment);
        }


        private void btnSafety_Click(
            object sender,
            EventArgs e)
        {
            SelectCategory(
                "Safety",
                btnSafety);
        }


        private void btnHealth_Click(
            object sender,
            EventArgs e)
        {
            SelectCategory(
                "Health",
                btnHealth);
        }


        private void btnEducation_Click(
            object sender,
            EventArgs e)
        {
            SelectCategory(
                "Education",
                btnEducation);
        }


        // =====================================================
        // SELECT CATEGORY
        //
        // Selecting a category filters the home screen.
        // It does NOT record a recommendation preference
        // until the user actually presses Search or views
        // an event.
        // =====================================================

        private void SelectCategory(
            string category,
            Button button)
        {
            selectedCategory =
                category;


            SetSelectedCategory(
                button);


            LoadEvents();
        }


        // =====================================================
        // CATEGORY STYLE
        // =====================================================

        private void SetSelectedCategory(
            Button selectedButton)
        {
            Button[] buttons =
            {
                btnAll,
                btnCommunity,
                btnEnvironment,
                btnSafety,
                btnHealth,
                btnEducation
            };


            foreach (
                Button button
                in buttons)
            {
                button.BackColor =
                    Color.FromArgb(
                        230,
                        243,
                        253);

                button.ForeColor =
                    Color.FromArgb(
                        0,
                        59,
                        113);
            }


            selectedButton.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            selectedButton.ForeColor =
                Color.White;
        }


        // =====================================================
        // BACK
        // =====================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}