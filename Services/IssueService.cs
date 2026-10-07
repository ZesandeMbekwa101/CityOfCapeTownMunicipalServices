using System;
using System.Collections.Generic;

using CityOfCapeTownMunicipalServices.DataStructures;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.Services
{
    public class IssueService
    {
        // =====================================================
        // SUBMIT ISSUE
        // =====================================================

        public bool SubmitIssue(
            string userEmail,
            string location,
            string category,
            string description,
            string attachmentPath,
            out IssueReport submittedIssue,
            out string message)
        {
            submittedIssue =
                null;


            // =================================================
            // BASIC SAFETY VALIDATION
            // =================================================

            if (string.IsNullOrWhiteSpace(
                location))
            {
                message =
                    "Location is required.";

                return false;
            }


            if (string.IsNullOrWhiteSpace(
                category))
            {
                message =
                    "Category is required.";

                return false;
            }


            if (string.IsNullOrWhiteSpace(
                description))
            {
                message =
                    "Description is required.";

                return false;
            }


            // =================================================
            // CREATE ISSUE
            // =================================================

            IssueReport issue =
                new IssueReport();

            issue.ReferenceNumber =
                GenerateReferenceNumber();

            issue.UserEmail =
                userEmail;

            issue.Location =
                location.Trim();

            issue.Category =
                category.Trim();

            issue.Description =
                description.Trim();

            issue.AttachmentPath =
                attachmentPath;

            issue.DateReported =
                DateTime.Now;

            issue.Status =
                "Submitted";


            // =================================================
            // STORE INSIDE LIST
            // =================================================

            bool added =
                IssueStore.AddIssue(
                    issue);


            if (!added)
            {
                message =
                    "There was a problem submitting your report.";

                return false;
            }


            submittedIssue =
                issue;

            message =
                "Report submitted successfully.";

            return true;
        }


        // =====================================================
        // USER'S ISSUES
        // =====================================================

        public List<IssueReport> GetUserIssues(
            string email)
        {
            return IssueStore.GetIssuesByUser(
                email);
        }


        // =====================================================
        // GENERATE REFERENCE NUMBER
        // =====================================================

        private string GenerateReferenceNumber()
        {
            int nextNumber =
                IssueStore.Count + 1;

            return string.Format(
                "CT-{0}-{1:D5}",
                DateTime.Now.Year,
                nextNumber);
        }
    }
}