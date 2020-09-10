// <copyright file="IParkingCitationReviewsData.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Data Access Interface for handling the application's general functionality</summary>

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using ParkingCitationReviews.EntityObject;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace ParkingCitationReviews.DataAccess
{
    /// <summary>
    /// Data Access Interface for handling the application's general functionality
    /// </summary>
    public interface IParkingCitationReviewsData
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
        /// Retrieves a Dictionary collection of Review Request reasons
        /// </summary>
        /// <returns></returns>
        Dictionary<int, string> GetRequestReasonList();

        /// <summary>
        /// Inserts a citation review record along with its corresponding notes into the database
        /// </summary>
        /// <returns></returns>
        void InsertCitationReviewRecord(ParkingCitationReviews.EntityObjects.CitationReview citationReview, EntityObjects.Note pcrNote, EntityObjects.ApplicationUser currentUser);

        /// <summary>
        /// Returns a boolean value for whether the citation number is unique to the database
        /// </summary>
        /// <returns></returns>
        bool CitationNumIsUnique(string citationNum);

        /// <summary>
        /// Returns a CitationReview object based on the given review number
        /// </summary>
        /// <returns></returns>
        EntityObjects.CitationReview GetCitationReview(int reviewNum);

        /// <summary>
        /// Returns a list of Note objects based on the given review number
        /// </summary>
        /// <returns></returns>
        List<EntityObjects.Note> GetNotes(int reviewNum);

        /// <summary>
        /// Inserts a new note for the specified review number into the database
        /// </summary>
        /// <returns></returns>
        void AddNote(EntityObjects.Note note);

        /// <summary>
        /// Updates the note in the database corresponding to the given Note obect
        /// </summary>
        /// <returns></returns>
        void UpdateNote(EntityObjects.Note note);

        /// <summary>
        /// Deletes the note in the database corresponding to the given note object 
        /// </summary>
        /// <returns></returns>
        void DeleteNote(EntityObjects.Note note, EntityObjects.ApplicationUser currentUser);

        /// <summary>
        /// Returns a list of CitationReview objects using the given searchText as search criteria
        /// </summary>
        /// <returns></returns>
        List<EntityObjects.CitationReview> GetSearchResults(string searchText);

        /// <summary>
        /// Returns a string representation of the total number of records returned from the Pending report based on the given date range
        /// </summary>
        /// <returns></returns>
        string GetPendingRecordCount(string dtStart, string dtEnd);

        /// <summary>
        /// Returns a DataView object containing the results of the Pending report based on the given date range, starting index, and page size
        /// </summary>
        /// <returns></returns>
        DataView GetPendingRecords(string dtStart, string dtEnd, int startRecord, int pageSize);

        /// <summary>
        /// Returns a string representation of the total number of records returned from the Court report based on the given date range
        /// </summary>
        /// <returns></returns>
        string GetCourtRecordCount(string dtStart, string dtEnd);

        /// <summary>
        /// Returns a DataView object containing the results of the Court report based on the given date range, starting index, and page size
        /// </summary>
        /// <returns></returns>
        DataView GetCourtRecords(string dtStart, string dtEnd, int startRecord, int pageSize);

        /// <summary>
        /// Updates the citation review record in the database corresponding to the given CitationReview object
        /// </summary>
        /// <returns></returns>
        void UpdateCitationReviewRecord(EntityObjects.CitationReview citationReview, EntityObjects.ApplicationUser currentUser);

        Database GetDB();

        int TimeofDayIdGet(string ItemDesc);
    }
}
