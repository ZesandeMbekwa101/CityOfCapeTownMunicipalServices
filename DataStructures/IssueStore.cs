using System;
using System.Collections.Generic;
using System.Linq;

using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.DataStructures
{
    public static class IssueStore
    {
        // =====================================================
        // MAIN DATA STRUCTURE
        // =====================================================

        private static readonly List<IssueReport> issues =
            new List<IssueReport>();


        // =====================================================
        // ADD ISSUE
        // =====================================================

        public static bool AddIssue(
            IssueReport issue)
        {
            if (issue == null)
            {
                return false;
            }

            issues.Add(issue);

            return true;
        }


        // =====================================================
        // GET ALL ISSUES
        // =====================================================

        public static List<IssueReport> GetAllIssues()
        {
            return new List<IssueReport>(
                issues);
        }


        // =====================================================
        // GET ISSUES FOR ONE USER
        // =====================================================

        public static List<IssueReport> GetIssuesByUser(
            string email)
        {
            if (string.IsNullOrWhiteSpace(
                email))
            {
                return new List<IssueReport>();
            }

            return issues
                .Where(issue =>
                    !string.IsNullOrWhiteSpace(
                        issue.UserEmail) &&
                    issue.UserEmail.Equals(
                        email,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }


        // =====================================================
        // FIND BY REFERENCE NUMBER
        // =====================================================

        public static IssueReport GetIssueByReference(
            string referenceNumber)
        {
            if (string.IsNullOrWhiteSpace(
                referenceNumber))
            {
                return null;
            }

            return issues
                .FirstOrDefault(issue =>
                    issue.ReferenceNumber.Equals(
                        referenceNumber,
                        StringComparison.OrdinalIgnoreCase));
        }


        // =====================================================
        // TOTAL NUMBER OF ISSUES
        // =====================================================

        public static int Count
        {
            get
            {
                return issues.Count;
            }
        }
    }
}