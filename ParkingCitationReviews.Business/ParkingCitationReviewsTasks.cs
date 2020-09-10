// <copyright file="ParkingCitationReviewsTasks.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Business Tier Class for handling the application's general functionality</summary>

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using ParkingCitationReviews.Business.Interfaces;
using ParkingCitationReviews.DataAccess;
using ParkingCitationReviews.EntityObjects;

namespace ParkingCitationReviews.Business
{
    /// <summary>
    /// Business Tier Class for handling the application's general functionality
    /// </summary>
    public class ParkingCitationReviewsTasks : IParkingCitationReviewsTasks
    {
        /// <summary>
        /// Private member field for interfacing with ParkingCitationReviewsData class in the data access tier 
        /// </summary>
        private readonly IParkingCitationReviewsData pcrData;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the ParkingCitationReviewsTasks class with an input parameter for ParkingCitationReviewsData
        /// </summary>
        /// <param name="securityData">ParkingCitationReviewsData object passed</param>
        public ParkingCitationReviewsTasks(IParkingCitationReviewsData pcrData)
        {
            this.pcrData = pcrData;
        }

        /// <summary>
        /// Initializes a new instance of the ParkingCitationReviewsTasks class with no input parameters
        /// </summary>
        public ParkingCitationReviewsTasks() : this(new ParkingCitationReviewsData())
        {
        }
        #endregion

        #region IParkingCitationReviewsTasks Members

        /// <summary>
        /// Retrieves a Dictionary collection of States 
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetStatesList()
        {
            try
            {
                return this.pcrData.GetStatesList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a Dictionary collection of Vehicle Makes
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetVehicleMakeList()
        {
            try
            {
                return this.pcrData.GetVehicleMakeList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a Dictionary collection of Street Types 
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetStreetTypeList()
        {
            try
            {
                return this.pcrData.GetStreetTypeList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a Dictionary collection of Review Determination options 
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetDeterminationList()
        {
            try
            {
                return this.pcrData.GetDeterminationList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a Dictionary collection of Review Request reasons
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetRequestReasonList()
        {
            try
            {
                return this.pcrData.GetRequestReasonList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sends a citation review object and a corresponding notes object to Data Access tier to be saved
        /// </summary>
        /// <returns></returns>
        public void InsertCitationReviewRecord(CitationReview citationReview, Note pcrNote, ApplicationUser currentUser)
        {
            try
            {
                this.pcrData.InsertCitationReviewRecord(citationReview, pcrNote, currentUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a boolean value for whether the citation number is unique to the system
        /// </summary>
        /// <returns></returns>
        public bool CitationNumIsUnique(string citationNum)
        {
            try
            {
                return this.pcrData.CitationNumIsUnique(citationNum);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a CitationReview object based on the given review number
        /// </summary>
        /// <returns></returns>
        public CitationReview GetCitationReview(int reviewNum)
        {
            try
            {
                return this.pcrData.GetCitationReview(reviewNum);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a list of Note objects based on the given review number
        /// </summary>
        /// <returns></returns>
        public List<Note> GetNotes(int reviewNum)
        {
            try
            {
                return this.pcrData.GetNotes(reviewNum);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sends a new note to Data Access tier to be saved
        /// </summary>
        /// <returns></returns>
        public void AddNote(Note note)
        {
            try
            {
                this.pcrData.AddNote(note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sends a Note obect to Data Access tier to be updated
        /// </summary>
        /// <returns></returns>
        public void UpdateNote(Note note)
        {
            try
            {
                this.pcrData.UpdateNote(note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sends call to Data Access tier to delete the note corresponding to the given note object
        /// </summary>
        /// <returns></returns>
        public void DeleteNote(Note note, ApplicationUser currentUser)
        {
            try
            {
                this.pcrData.DeleteNote(note, currentUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a list of CitationReview objects using the given searchText as search criteria
        /// </summary>
        /// <returns></returns>
        public List<CitationReview> GetSearchResults(string searchText)
        {
            try
            {
                return this.pcrData.GetSearchResults(searchText);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a string representation of the total number of records returned from the Pending report based on the given date range
        /// </summary>
        /// <returns></returns>
        public string GetPendingRecordCount(string dtStart, string dtEnd)
        {
            try
            {
                return this.pcrData.GetPendingRecordCount(dtStart, dtEnd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a DataView object containing the results of the Pending report based on the given date range, starting index, and page size
        /// </summary>
        /// <returns></returns>
        public DataView GetPendingRecords(string dtStart, string dtEnd, int startRecord, int pageSize)
        {
            try
            {
                return this.pcrData.GetPendingRecords(dtStart, dtEnd, startRecord, pageSize);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a string representation of the total number of records returned from the Court report based on the given date range
        /// </summary>
        /// <returns></returns>
        public string GetCourtRecordCount(string dtStart, string dtEnd)
        {
            try
            {
                return this.pcrData.GetCourtRecordCount(dtStart, dtEnd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves a DataView object containing the results of the Court report based on the given date range, starting index, and page size
        /// </summary>
        /// <returns></returns>
        public DataView GetCourtRecords(string dtStart, string dtEnd, int startRecord, int pageSize)
        {
            try
            {
                return this.pcrData.GetCourtRecords(dtStart, dtEnd, startRecord, pageSize);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sends a citation review object to Data Access tier to update the corresponding database record
        /// </summary>
        /// <returns></returns>
        public void UpdateCitationReviewRecord(CitationReview citationReview, ApplicationUser currentUser)
        {
            try
            {
                this.pcrData.UpdateCitationReviewRecord(citationReview, currentUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
