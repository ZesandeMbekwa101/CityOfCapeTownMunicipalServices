using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;

namespace CityOfCapeTownMunicipalServices.Forms.Events
{
    public partial class RecommendedEventsForm : Form
    {
        private readonly EventService eventService;


        public RecommendedEventsForm()
        {
            InitializeComponent();


            eventService =
                new EventService();


            LoadRecommendations();
        }


        // =====================================================
        // LOAD
        // =====================================================

        private void LoadRecommendations()
        {
            pnlRecommendations
                .Controls
                .Clear();


            List<MunicipalEvent> events =
                eventService
                    .GetRecommendations(
                        6);


            string preferredCategory =
                eventService
                    .GetPreferredCategory();


            if (string.IsNullOrWhiteSpace(
                preferredCategory))
            {
                lblSubtitle.Text =
                    "Search for events or view event details to personalise your recommendations.";
            }
            else
            {
                lblSubtitle.Text =
                    "Based on your recent interest in " +
                    preferredCategory +
                    " events.";
            }


            foreach (
                MunicipalEvent municipalEvent
                in events)
            {
                pnlRecommendations.Controls.Add(
                    CreateCard(
                        municipalEvent));
            }
        }


        // =====================================================
        // CARD
        // =====================================================

        private Panel CreateCard(
            MunicipalEvent municipalEvent)
        {
            Panel card =
                new Panel();

            card.Size =
                new Size(
                    430,
                    210);

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


            Label date =
                new Label();

            date.Text =
                municipalEvent.EventDate
                    .ToString(
                        "dd\nMMM")
                    .ToUpper();

            date.Location =
                new Point(
                    15,
                    20);

            date.Size =
                new Size(
                    65,
                    65);

            date.TextAlign =
                ContentAlignment.MiddleCenter;

            date.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            date.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            Label title =
                new Label();

            title.Text =
                municipalEvent.Title;

            title.Location =
                new Point(
                    95,
                    18);

            title.Size =
                new Size(
                    305,
                    45);

            title.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            title.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            Label category =
                new Label();

            category.Text =
                municipalEvent.Category;

            category.Location =
                new Point(
                    95,
                    70);

            category.AutoSize =
                true;

            category.ForeColor =
                Color.FromArgb(
                    0,
                    119,
                    200);


            Label details =
                new Label();

            details.Text =
                "◷ " +
                municipalEvent.EventDate
                    .ToString("HH:mm") +
                " - " +
                municipalEvent.EndDate
                    .ToString("HH:mm") +
                "\n● " +
                municipalEvent.Location;

            details.Location =
                new Point(
                    95,
                    100);

            details.Size =
                new Size(
                    300,
                    50);

            details.ForeColor =
                Color.Gray;


            Button view =
                new Button();

            view.Text =
                "View Details";

            view.Location =
                new Point(
                    275,
                    160);

            view.Size =
                new Size(
                    125,
                    35);

            view.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            view.ForeColor =
                Color.White;

            view.FlatStyle =
                FlatStyle.Flat;

            view.FlatAppearance.BorderSize =
                0;

            view.Tag =
                municipalEvent.EventId;

            view.Cursor =
                Cursors.Hand;

            view.Click +=
                btnViewDetails_Click;


            card.Controls.Add(
                date);

            card.Controls.Add(
                title);

            card.Controls.Add(
                category);

            card.Controls.Add(
                details);

            card.Controls.Add(
                view);


            return card;
        }


        // =====================================================
        // VIEW
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
                EventDetailsForm form =
                    new EventDetailsForm(
                        eventId))
            {
                form.ShowDialog(
                    this);
            }


            // Recalculate after viewing.
            LoadRecommendations();
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