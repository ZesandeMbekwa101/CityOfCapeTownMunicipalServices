using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.Forms.Events
{
    public partial class SearchResultsForm : Form
    {
        private readonly
            List<MunicipalEvent>
            searchResults;


        public SearchResultsForm(
            string searchText,
            string category,
            List<MunicipalEvent> results)
        {
            InitializeComponent();


            searchResults =
                results ??
                new List<MunicipalEvent>();


            string searchDescription;


            if (string.IsNullOrWhiteSpace(
                searchText))
            {
                searchDescription =
                    "Category search";
            }
            else
            {
                searchDescription =
                    "\"" +
                    searchText.Trim() +
                    "\"";
            }


            string categoryDescription =
                category;


            if (string.IsNullOrWhiteSpace(
                categoryDescription))
            {
                categoryDescription =
                    "All";
            }


            lblSearchInfo.Text =
                searchResults.Count +
                " result(s) found for " +
                searchDescription +
                "  •  Category: " +
                categoryDescription;


            LoadResults();
        }


        // =====================================================
        // LOAD RESULTS
        // =====================================================

        private void LoadResults()
        {
            pnlResults.Controls.Clear();


            if (searchResults.Count == 0)
            {
                Label empty =
                    new Label();


                empty.Text =
                    "No matching events were found.\n\n" +
                    "Try searching for words such as:\n" +
                    "career, recycling, health, safety, reading or community.";

                empty.Size =
                    new Size(
                        820,
                        180);

                empty.TextAlign =
                    ContentAlignment.MiddleCenter;

                empty.Font =
                    new Font(
                        "Segoe UI",
                        11F,
                        FontStyle.Bold);

                empty.ForeColor =
                    Color.Gray;


                pnlResults.Controls.Add(
                    empty);


                return;
            }


            foreach (
                MunicipalEvent municipalEvent
                in searchResults)
            {
                pnlResults.Controls.Add(
                    CreateResultCard(
                        municipalEvent));
            }
        }


        // =====================================================
        // RESULT CARD
        // =====================================================

        private Panel CreateResultCard(
            MunicipalEvent municipalEvent)
        {
            Panel card =
                new Panel();


            card.Width =
                Math.Max(
                    700,
                    pnlResults.ClientSize.Width -
                    30);

            card.Height =
                145;

            card.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    15);

            card.BackColor =
                Color.White;

            card.BorderStyle =
                BorderStyle.FixedSingle;


            // DATE

            Label date =
                new Label();


            date.Text =
                municipalEvent
                    .EventDate
                    .ToString(
                        "dd\nMMM")
                    .ToUpper();

            date.Location =
                new Point(
                    15,
                    20);

            date.Size =
                new Size(
                    70,
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


            // TITLE

            Label title =
                new Label();


            title.Text =
                municipalEvent.Title;

            title.Location =
                new Point(
                    100,
                    15);

            title.Size =
                new Size(
                    card.Width - 280,
                    30);

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


            // DETAILS

            Label details =
                new Label();


            details.Text =
                "Time: " +
                municipalEvent
                    .EventDate
                    .ToString("HH:mm") +
                " - " +
                municipalEvent
                    .EndDate
                    .ToString("HH:mm") +
                "\nLocation: " +
                municipalEvent.Location +
                "\nCategory: " +
                municipalEvent.Category;

            details.Location =
                new Point(
                    100,
                    52);

            details.Size =
                new Size(
                    card.Width - 280,
                    75);

            details.ForeColor =
                Color.Gray;


            // VIEW DETAILS

            Button view =
                new Button();


            view.Text =
                "View Details";

            view.Size =
                new Size(
                    125,
                    38);

            view.Location =
                new Point(
                    card.Width - 150,
                    52);

            view.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

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

            view.Cursor =
                Cursors.Hand;

            view.Tag =
                municipalEvent.EventId;

            view.Click +=
                btnViewDetails_Click;


            card.Controls.Add(
                date);

            card.Controls.Add(
                title);

            card.Controls.Add(
                details);

            card.Controls.Add(
                view);


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
                EventDetailsForm form =
                    new EventDetailsForm(
                        eventId))
            {
                form.ShowDialog(
                    this);
            }
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