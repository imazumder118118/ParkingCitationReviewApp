// <copyright file="IParkingCitationReviewsTasks.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Business Tier Interface for handling the application's general functionality</summary>

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using ParkingCitationReviews.EntityObjects;

namespace ParkingCitationReviews.Business.Interfaces
{
    /// <summary>
    /// Business Tier Interface for handling the application's general functionality
    /// </summary>
    public interface IParkingCitationReviewsTasks
    {
        /// <summary>
        /// Retrieves a Dictionary collection of States 
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetStatesList();

        /// <summary>
        /// Retrieves a Dictionary collection of Vehicle Makes 
        /// </summary>
        /// <returns></returns>
        Dictionary<int, string> GetVehicleMakeList();

        /// <summary>
        /// Retrieves a Dictionary collection of Street Types 
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetStreetTypeList();

        /// <summary>
        /// Retrieves a Dictionary collection of Review Determination Options
        /// </summary>
        /// <returns></returns>
        Dictionary<int, string> GetDeterminationList();

        /// <summary>
        /// Retrieves a Dictionary collection of Review Request Reasons
        /// </summary>
        /// <returns></returns>
        Dictionary<int, string> GetRequestReasonList();

        /// <summary>
        /// Sends a citation review object and a corresponding notes object to Data Access tier to be saved
        /// </summary>
        /// <returns></returns>
        void InsertCitationReviewRecord(CitationReview citationReview, Note pcrNote, ApplicationUser currentUser);

        /// <summary>
        /// Retrieves a boolean value for whether the citation number is unique to the system
        /// </summary>
        /// <returns></returns>
        bool CitationNumIsUnique(string citationNum);

        /// <summary>
        /// Retrieves a CitationReview object based on the given review number
        /// </summary>
        /// <returns></returns>
        CitationReview GetCitationReview(int reviewNum);

        /// <summary>
        /// Retrieves a list of Note objects based on the given review number
        /// </summary>
        /// <returns></returns>
        List<Note> GetNotes(int reviewNum);

        /// <summary>
        /// Sends a new note to Data Access tier to be saved
        /// </summary>
        /// <returns></returns>
        void AddNote(Note note);

        /// <summary>
        /// Sends a Note obect to Data Access tier to be updated
        /// </summary>
        /// <returns></returns>
        void UpdateNote(Note note);

        /// <summary>
        /// Sends call to Data Access tier to delete the note corresponding to the given note object
        /// </summary>
        /// <returns></returns>
        void DeleteNote(Note note, ApplicationUser currentUser);

        /// <summary>
        /// Retrieves a list of CitationReview objects using the given searchText as search criteria
        /// </summary>
        /// <returns></returns>
        List<CitationReview> GetSearchResults(string searchText);

        /// <summary>
        /// Retrieves a string representation of the total number of records returned from the Pending report based on the given date range
        /// </summary>
        /// <returns></returns>
        string GetPendingRecordCount(string dtStart, string dtEnd);

        /// <summary>
        /// Retrieves a DataView object containing the results of the Pending report based on the given date range, starting index, and page size
        /// </summary>
        /// <returns></returns>
        DataView GetPendingRecords(string dtStart, string dtEnd, int startRecord, int pageSize);

        /// <summary>
        /// Retrieves a string representation of the total number of records returned from the Court report based on the given date range
        /// </summary>
        /// <returns></returns>
        string GetCourtRecordCount(string dtStart, string dtEnd);

        /// <summary>
        /// Retrieves a DataView object containing the results of the Court report based on the given date range, starting index, and page size
        /// </summary>
        /// <returns></returns>
        DataView GetCourtRecords(string dtStart, string dtEnd, int startRecord, int pageSize);

        /// <summary>
        /// Sends a citation review object to Data Access tier to update the corresponding database record
        /// </summary>
        /// <returns></returns>
        void UpdateCitationReviewRecord(CitationReview citationReview, ApplicationUser currentUser);
    }
}
