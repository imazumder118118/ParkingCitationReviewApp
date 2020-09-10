// <copyright file="ParkingCitationReviewsData.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Class for handling data access related to the application's general functionality</summary>

using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ParkingCitationReviews.Logging;
using ParkingCitationReviews.EntityObjects;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Common;

namespace ParkingCitationReviews.DataAccess
{
    /// <summary>
    /// Class for handling data access related to the application's general functionality
    /// </summary>
    public class ParkingCitationReviewsData : IParkingCitationReviewsData
    {
        #region IParkingCitationReviewsData Members

        public System.Collections.Generic.Dictionary<string, string> GetStatesList()
        {
            
            try
            {
                Dictionary<string, string> stateDictionary = new Dictionary<string, string>();

                // Get the list of states from the database

                // Return the states dictionary collection
                stateDictionary.Add("AK", "Alaska");
                stateDictionary.Add("AL", "Alabama");
                stateDictionary.Add("AR", "Arkansas");
                stateDictionary.Add("AZ", "Arizona");
                stateDictionary.Add("CA", "California");
                stateDictionary.Add("CO", "Colorado");
                stateDictionary.Add("CT", "Connecticut");
                stateDictionary.Add("DC", "District of Columbia");
                stateDictionary.Add("DE", "Delaware");
                stateDictionary.Add("FL", "Florida");
                stateDictionary.Add("GA", "Georgia");
                stateDictionary.Add("GU", "Guam");
                stateDictionary.Add("HI", "Hawaii");
                stateDictionary.Add("IA", "Iowa");
                stateDictionary.Add("ID", "Idaho");
                stateDictionary.Add("IL", "Illinois");
                stateDictionary.Add("IN", "Indiana");
                stateDictionary.Add("KS", "Kansas");
                stateDictionary.Add("KY", "Kentucky");
                stateDictionary.Add("LA", "Louisiana");
                stateDictionary.Add("MA", "Massachusetts");
                stateDictionary.Add("MD", "Maryland");
                stateDictionary.Add("ME", "Maine");
                stateDictionary.Add("MI", "Michigan");
                stateDictionary.Add("MN", "Minnesota");
                stateDictionary.Add("MO", "Missouri");
                stateDictionary.Add("MS", "Mississippi");
                stateDictionary.Add("MT", "Montana");
                stateDictionary.Add("NC", "North Carolina");
                stateDictionary.Add("ND", "North Dakota");
                stateDictionary.Add("NE", "Nebraska");
                stateDictionary.Add("NH", "New Hampshire");
                stateDictionary.Add("NJ", "New Jersey");
                stateDictionary.Add("NM", "New Mexico");
                stateDictionary.Add("NV", "Nevada");
                stateDictionary.Add("NY", "New York");
                stateDictionary.Add("OH", "Ohio");
                stateDictionary.Add("OK", "Oklahoma");
                stateDictionary.Add("OR", "Oregon");
                stateDictionary.Add("PA", "Pennsylvania");
                stateDictionary.Add("PR", "Puerto Rico");
                stateDictionary.Add("RI", "Rhode Island");
                stateDictionary.Add("SC", "South Carolina");
                stateDictionary.Add("SD", "South Dakota");
                stateDictionary.Add("TN", "Tennessee");
                stateDictionary.Add("TX", "Texas");
                stateDictionary.Add("UT", "Utah");
                stateDictionary.Add("VA", "Virginia");
                stateDictionary.Add("VT", "Vermont");
                stateDictionary.Add("WA", "Washington");
                stateDictionary.Add("WI", "Wisconsin");
                stateDictionary.Add("WV", "West Virginia");
                stateDictionary.Add("WY", "Wyoming");






                return stateDictionary;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);

                // throw up to next tier
                throw;
            }

        }

        public System.Collections.Generic.Dictionary<int, string> GetVehicleMakeList()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                Dictionary<int, string> vehicleMakeDictionary = new Dictionary<int, string>();

                // Get the list of vehicle makes from the database
                string strSQL = "SELECT VehicleMakeID, VehicleMake FROM VEHICLEMAKEINDEX ORDER BY VehicleMake";
                dbCmd = sqlDB.GetSqlStringCommand(strSQL);
                IDataReader drResults = sqlDB.ExecuteReader(dbCmd);

                // Add each vehicle make record to the dictionary collection
                while (drResults.Read())
                {
                    vehicleMakeDictionary.Add(Convert.ToInt32(drResults["VehicleMakeID"]), drResults["VehicleMake"].ToString());
                }

                // Return the vehicle make dictionary collection
                return vehicleMakeDictionary;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        public System.Collections.Generic.Dictionary<string, string> GetStreetTypeList()
        {
            try
            {
               
                Dictionary<string, string> streetTypesDictionary = new Dictionary<string, string>();

                // Get the list of street types from the CentralAddressService web service

                string[] arrStreetTypes = new string[] { "AI", "Ave", "Blvd", "Cir", "Cncs", "Conn", "Cres", "Ct", "Dr", "Expy", "Hwy", "Lane", "Loop", "Park", "Pkwy", "Pl", "Plz", "Pt", "Road", "Row", "Sq", "St", "Ter", "Tpke", "Trce", "Trl", "Way" };

                    for (int i = 0; i < arrStreetTypes.Length; i++)
                    {
                        streetTypesDictionary.Add(arrStreetTypes[i], arrStreetTypes[i]);
                    }

                // Return the street types dictionary collection
                return streetTypesDictionary;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
        }

        public System.Collections.Generic.Dictionary<int, string> GetDeterminationList()
        {

            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                Dictionary<int, string> determinationDictionary = new Dictionary<int, string>();

                // Get the list of review determination options from the database
                string strSQL = "SELECT DeterminationID, Determination FROM DETERMINATIONINDEX ORDER BY DeterminationID";
                dbCmd = sqlDB.GetSqlStringCommand(strSQL);
                IDataReader drResults = sqlDB.ExecuteReader(dbCmd);

                // Add each determination record to the dictionary collection
                while (drResults.Read())
                {
                    determinationDictionary.Add(Convert.ToInt32(drResults["DeterminationID"]), drResults["Determination"].ToString());
                }

                // Return the determination dictionary collection
                return determinationDictionary;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }


        public System.Collections.Generic.Dictionary<int, string> GetRequestReasonList()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                Dictionary<int, string> requestReasonDictionary = new Dictionary<int, string>();

                // Get the list of review request reasons from the database
                string strSQL = "SELECT ReasonID, ReasonDescription FROM REVIEWREASONINDEX ORDER BY ReasonDescription";
                dbCmd = sqlDB.GetSqlStringCommand(strSQL);
                IDataReader drResults = sqlDB.ExecuteReader(dbCmd);

                // Add each request reason record to the dictionary collection
                while (drResults.Read())
                {
                    requestReasonDictionary.Add(Convert.ToInt32(drResults["ReasonID"]), drResults["ReasonDescription"].ToString());
                }

                // Return the request reason dictionary collection
                return requestReasonDictionary;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Inserts a citation review record along with its corresponding notes into the database
        /// </summary>
        /// <returns></returns>
        public void InsertCitationReviewRecord(CitationReview citationReview, Note pcrNote, ApplicationUser currentUser)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                dbCmd = sqlDB.GetStoredProcCommand("proc_InsertCitationReview");

                List<DbParameter> parameters = new List<DbParameter>();

                // Map the fields of the citation review and note objects to the parameters of the stored procedure
                DbParameter citationNumParam = dbCmd.CreateParameter();
                citationNumParam.ParameterName = "@CitationNumber";
                citationNumParam.DbType = DbType.String;
                citationNumParam.Size = 15;
                citationNumParam.Value = citationReview.CitationNum;
                parameters.Add(citationNumParam);

                DbParameter requestDtParam = dbCmd.CreateParameter();
                requestDtParam.ParameterName = "@RequestDate";
                requestDtParam.DbType = DbType.DateTime;
                requestDtParam.Size = 8;
                requestDtParam.Value = citationReview.RequestDt;
                parameters.Add(requestDtParam);

                DbParameter issueDtParam = dbCmd.CreateParameter();
                issueDtParam.ParameterName = "@CitationIssueDate";
                issueDtParam.DbType = DbType.DateTime;
                issueDtParam.Size = 8;
                issueDtParam.Value = citationReview.IssueDt;
                parameters.Add(issueDtParam);

                DbParameter recipientLNameParam = dbCmd.CreateParameter();
                recipientLNameParam.ParameterName = "@RecipientLastName";
                recipientLNameParam.DbType = DbType.String;
                recipientLNameParam.Size = 25;
                recipientLNameParam.Value = citationReview.RecipientLName;
                parameters.Add(recipientLNameParam);

                DbParameter recipientFNameParam = dbCmd.CreateParameter();
                recipientFNameParam.ParameterName = "@RecipientFirstName";
                recipientFNameParam.DbType = DbType.String;
                recipientFNameParam.Size = 25;
                recipientFNameParam.Value = citationReview.RecipientFName;
                parameters.Add(recipientFNameParam);

                DbParameter recipientMidInitialParam = dbCmd.CreateParameter();
                recipientMidInitialParam.ParameterName = "@RecipientMiddleInitial";
                recipientMidInitialParam.DbType = DbType.String;
                recipientMidInitialParam.Size = 1;
                recipientMidInitialParam.Value = citationReview.RecipientMidInitial;
                parameters.Add(recipientMidInitialParam);

                DbParameter plateNumParam = dbCmd.CreateParameter();
                plateNumParam.ParameterName = "@PlateNumber";
                plateNumParam.DbType = DbType.String;
                plateNumParam.Size = 50;
                plateNumParam.Value = citationReview.PlateNum;
                parameters.Add(plateNumParam);

                DbParameter plateStateParam = dbCmd.CreateParameter();
                plateStateParam.ParameterName = "@PlateState";
                plateStateParam.DbType = DbType.String;
                plateStateParam.Size = 2;
                plateStateParam.Value = citationReview.PlateState;
                parameters.Add(plateStateParam);

                DbParameter vehicleMakeIDParam = dbCmd.CreateParameter();
                vehicleMakeIDParam.ParameterName = "@VehicleMakeID";
                vehicleMakeIDParam.DbType = DbType.Int32;
                vehicleMakeIDParam.Size = 4;
                if (citationReview.VehicleMakeID == 0)
                    vehicleMakeIDParam.Value = DBNull.Value;
                else
                    vehicleMakeIDParam.Value = citationReview.VehicleMakeID;
                parameters.Add(vehicleMakeIDParam);

                DbParameter vehicleModelParam = dbCmd.CreateParameter();
                vehicleModelParam.ParameterName = "@VehicleModel";
                vehicleModelParam.DbType = DbType.String;
                vehicleModelParam.Size = 20;
                vehicleModelParam.Value = citationReview.VehicleModel;
                parameters.Add(vehicleModelParam);

                DbParameter citationAddrDirParam = dbCmd.CreateParameter();
                citationAddrDirParam.ParameterName = "@CitationAddressDirection";
                citationAddrDirParam.DbType = DbType.String;
                citationAddrDirParam.Size = 5;
                citationAddrDirParam.Value = citationReview.CitationAddrDir;
                parameters.Add(citationAddrDirParam);

                DbParameter citationAddrNumParam = dbCmd.CreateParameter();
                citationAddrNumParam.ParameterName = "@CitationAddressNumber";
                citationAddrNumParam.DbType = DbType.String;
                citationAddrNumParam.Size = 50;
                citationAddrNumParam.Value = citationReview.CitationAddrNum;
                parameters.Add(citationAddrNumParam);

                DbParameter citationAddrStreetParam = dbCmd.CreateParameter();
                citationAddrStreetParam.ParameterName = "@CitationAddressStreet";
                citationAddrStreetParam.DbType = DbType.String;
                citationAddrStreetParam.Size = 100;
                citationAddrStreetParam.Value = citationReview.CitationAddrStreet;
                parameters.Add(citationAddrStreetParam);

                DbParameter citationAddrStreetTypeParam = dbCmd.CreateParameter();
                citationAddrStreetTypeParam.ParameterName = "@CitationAddressType";
                citationAddrStreetTypeParam.DbType = DbType.String;
                citationAddrStreetTypeParam.Size = 50;
                citationAddrStreetTypeParam.Value = citationReview.CitationAddrStreetType;
                parameters.Add(citationAddrStreetTypeParam);

                DbParameter reviewReasonIDParam = dbCmd.CreateParameter();
                reviewReasonIDParam.ParameterName = "@ReasonID";
                reviewReasonIDParam.DbType = DbType.Int32;
                reviewReasonIDParam.Size = 4;
                if (citationReview.ReviewReasonID == 0)
                    reviewReasonIDParam.Value = DBNull.Value;
                else
                    reviewReasonIDParam.Value = citationReview.ReviewReasonID;
                parameters.Add(reviewReasonIDParam);

                DbParameter reviewReasonExpParam = dbCmd.CreateParameter();
                reviewReasonExpParam.ParameterName = "@ReasonExplanation";
                reviewReasonExpParam.DbType = DbType.String;
                reviewReasonExpParam.Size = 2000;
                reviewReasonExpParam.Value = citationReview.ReviewReasonExp;
                parameters.Add(reviewReasonExpParam);

                DbParameter physicianParam = dbCmd.CreateParameter();
                physicianParam.ParameterName = "@AttendingPhysician";
                physicianParam.DbType = DbType.String;
                physicianParam.Size = 50;
                physicianParam.Value = citationReview.Physician;
                parameters.Add(physicianParam);

                DbParameter physicianVisitDtParam = dbCmd.CreateParameter();
                physicianVisitDtParam.ParameterName = "@PhysicianVisitDate";
                physicianVisitDtParam.DbType = DbType.DateTime;
                physicianVisitDtParam.Size = 8;
                if (citationReview.PhysicianVisitDt == DateTime.MinValue)
                    physicianVisitDtParam.Value = DBNull.Value;
                else
                    physicianVisitDtParam.Value = citationReview.PhysicianVisitDt;
                parameters.Add(physicianVisitDtParam);

                DbParameter recipientAddr1Param = dbCmd.CreateParameter();
                recipientAddr1Param.ParameterName = "@RecipientAddress1";
                recipientAddr1Param.DbType = DbType.String;
                recipientAddr1Param.Size = 100;
                recipientAddr1Param.Value = citationReview.RecipientAddr1;
                parameters.Add(recipientAddr1Param);

                DbParameter recipientAddr2Param = dbCmd.CreateParameter();
                recipientAddr2Param.ParameterName = "@RecipientAddress2";
                recipientAddr2Param.DbType = DbType.String;
                recipientAddr2Param.Size = 100;
                recipientAddr2Param.Value = citationReview.RecipientAddr2;
                parameters.Add(recipientAddr2Param);

                DbParameter recipientAddrCityParam = dbCmd.CreateParameter();
                recipientAddrCityParam.ParameterName = "@RecipientAddressCity";
                recipientAddrCityParam.DbType = DbType.String;
                recipientAddrCityParam.Size = 50;
                recipientAddrCityParam.Value = citationReview.RecipientAddrCity;
                parameters.Add(recipientAddrCityParam);

                DbParameter recipientAddrStateParam = dbCmd.CreateParameter();
                recipientAddrStateParam.ParameterName = "@RecipientAddressState";
                recipientAddrStateParam.DbType = DbType.String;
                recipientAddrStateParam.Size = 2;
                recipientAddrStateParam.Value = citationReview.RecipientAddrState;
                parameters.Add(recipientAddrStateParam);

                DbParameter recipientAddrZipParam = dbCmd.CreateParameter();
                recipientAddrZipParam.ParameterName = "@RecipientAddressZip";
                recipientAddrZipParam.DbType = DbType.String;
                recipientAddrZipParam.Size = 10;
                recipientAddrZipParam.Value = citationReview.RecipientAddrZip;
                parameters.Add(recipientAddrZipParam);

                DbParameter recipientEmailAddrParam = dbCmd.CreateParameter();
                recipientEmailAddrParam.ParameterName = "@RecipientEmailAddress";
                recipientEmailAddrParam.DbType = DbType.String;
                recipientEmailAddrParam.Size = 50;
                recipientEmailAddrParam.Value = citationReview.RecipientEmailAddr;
                parameters.Add(recipientEmailAddrParam);

                DbParameter recipientHomeNumParam = dbCmd.CreateParameter();
                recipientHomeNumParam.ParameterName = "@RecipientHomePhone";
                recipientHomeNumParam.DbType = DbType.String;
                recipientHomeNumParam.Size = 15;
                recipientHomeNumParam.Value = citationReview.RecipientHomeNum;
                parameters.Add(recipientHomeNumParam);

                DbParameter recipientWorkNumParam = dbCmd.CreateParameter();
                recipientWorkNumParam.ParameterName = "@RecipientWorkPhone";
                recipientWorkNumParam.DbType = DbType.String;
                recipientWorkNumParam.Size = 15;
                recipientWorkNumParam.Value = citationReview.RecipientWorkNum;
                parameters.Add(recipientWorkNumParam);

                DbParameter recipientWorkNumExtParam = dbCmd.CreateParameter();
                recipientWorkNumExtParam.ParameterName = "@RecipientWorkExt";
                recipientWorkNumExtParam.DbType = DbType.String;
                recipientWorkNumExtParam.Size = 6;
                recipientWorkNumExtParam.Value = citationReview.RecipientWorkNumExt;
                parameters.Add(recipientWorkNumExtParam);

                DbParameter internalReceiveDtParam = dbCmd.CreateParameter();
                internalReceiveDtParam.ParameterName = "@InternalDateReceived";
                internalReceiveDtParam.DbType = DbType.DateTime;
                internalReceiveDtParam.Size = 8;
                if (citationReview.InternalReceiveDt == DateTime.MinValue)
                    internalReceiveDtParam.Value = DBNull.Value;
                else
                    internalReceiveDtParam.Value = citationReview.InternalReceiveDt;
                parameters.Add(internalReceiveDtParam);

                DbParameter internalReceivedByParam = dbCmd.CreateParameter();
                internalReceivedByParam.ParameterName = "@InternalReceivedBy";
                internalReceivedByParam.DbType = DbType.String;
                internalReceivedByParam.Size = 50;
                internalReceivedByParam.Value = citationReview.InternalReceivedBy;
                parameters.Add(internalReceivedByParam);

                DbParameter determinationParam = dbCmd.CreateParameter();
                determinationParam.ParameterName = "@DeterminationID";
                determinationParam.DbType = DbType.Int32;
                determinationParam.Size = 4;
                if (citationReview.Determination == -1)
                    determinationParam.Value = DBNull.Value;
                else
                    determinationParam.Value = citationReview.Determination;
                parameters.Add(determinationParam);

                DbParameter reviewerID1Param = dbCmd.CreateParameter();
                reviewerID1Param.ParameterName = "@ReviewedByID1";
                reviewerID1Param.DbType = DbType.Int32;
                reviewerID1Param.Size = 4;
                if (citationReview.ReviewerID1 == 0)
                    reviewerID1Param.Value = DBNull.Value;
                else
                    reviewerID1Param.Value = citationReview.ReviewerID1;
                parameters.Add(reviewerID1Param);

                DbParameter reviewerID2Param = dbCmd.CreateParameter();
                reviewerID2Param.ParameterName = "@ReviewedByID2";
                reviewerID2Param.DbType = DbType.Int32;
                reviewerID2Param.Size = 4;
                if (citationReview.ReviewerID2 == 0)
                    reviewerID2Param.Value = DBNull.Value;
                else
                    reviewerID2Param.Value = citationReview.ReviewerID2;
                parameters.Add(reviewerID2Param);

                DbParameter extReviewedByName1Param = dbCmd.CreateParameter();
                extReviewedByName1Param.ParameterName = "@ExtReviewedByName1";
                extReviewedByName1Param.DbType = DbType.String;
                extReviewedByName1Param.Size = 50;
                extReviewedByName1Param.Value = citationReview.ExtReviewerName1;
                parameters.Add(extReviewedByName1Param);

                DbParameter extReviewedByName2Param = dbCmd.CreateParameter();
                extReviewedByName2Param.ParameterName = "@ExtReviewedByName2";
                extReviewedByName2Param.DbType = DbType.String;
                extReviewedByName2Param.Size = 50;
                extReviewedByName2Param.Value = citationReview.ExtReviewerName2;
                parameters.Add(extReviewedByName2Param);

                DbParameter reviewDtParam = dbCmd.CreateParameter();
                reviewDtParam.ParameterName = "@InternalReviewDate";
                reviewDtParam.DbType = DbType.DateTime;
                reviewDtParam.Size = 8;
                if (citationReview.ReviewDt == DateTime.MinValue)
                    reviewDtParam.Value = DBNull.Value;
                else
                    reviewDtParam.Value = citationReview.ReviewDt;
                parameters.Add(reviewDtParam);

                DbParameter excusedDtParam = dbCmd.CreateParameter();
                excusedDtParam.ParameterName = "@DateExcused";
                excusedDtParam.DbType = DbType.DateTime;
                excusedDtParam.Size = 8;
                if (citationReview.ExcusedDt == DateTime.MinValue)
                    excusedDtParam.Value = DBNull.Value;
                else
                    excusedDtParam.Value = citationReview.ExcusedDt;
                parameters.Add(excusedDtParam);

                DbParameter paidDtParam = dbCmd.CreateParameter();
                paidDtParam.ParameterName = "@DatePaid";
                paidDtParam.DbType = DbType.DateTime;
                paidDtParam.Size = 8;
                if (citationReview.PaidDt == DateTime.MinValue)
                    paidDtParam.Value = DBNull.Value;
                else
                    paidDtParam.Value = citationReview.PaidDt;
                parameters.Add(paidDtParam);

                DbParameter amountPaidParam = dbCmd.CreateParameter();
                amountPaidParam.ParameterName = "@AmountPaid";
                amountPaidParam.DbType = DbType.Decimal;
                amountPaidParam.Size = 9;
                if (citationReview.AmountPaid == 0)
                    amountPaidParam.Value = DBNull.Value;
                else
                    amountPaidParam.Value = citationReview.AmountPaid;
                parameters.Add(amountPaidParam);

                DbParameter recommendedExcusedAmtParam = dbCmd.CreateParameter();
                recommendedExcusedAmtParam.ParameterName = "@AmountExcused";
                recommendedExcusedAmtParam.DbType = DbType.Decimal;
                recommendedExcusedAmtParam.Size = 9;
                if (citationReview.RecommendedExcusedAmt == 0)
                    recommendedExcusedAmtParam.Value = DBNull.Value;
                else
                    recommendedExcusedAmtParam.Value = citationReview.RecommendedExcusedAmt;
                parameters.Add(recommendedExcusedAmtParam);

                DbParameter systemNoteParam = dbCmd.CreateParameter();
                systemNoteParam.ParameterName = "@SystemNote";
                systemNoteParam.DbType = DbType.String;
                systemNoteParam.Size = 2000;
                systemNoteParam.Value = "This citation review record was added by " + currentUser.UserName + ".";
                parameters.Add(systemNoteParam);

                DbParameter userNoteByParam = dbCmd.CreateParameter();
                userNoteByParam.ParameterName = "@UserNoteBy";
                userNoteByParam.DbType = DbType.Int32;
                userNoteByParam.Size = 4;
                userNoteByParam.Value = pcrNote.NoteByID;
                parameters.Add(userNoteByParam);

                DbParameter userNoteParam = dbCmd.CreateParameter();
                userNoteParam.ParameterName = "@UserNote";
                userNoteParam.DbType = DbType.String;
                userNoteParam.Size = 2000;
                userNoteParam.Value = pcrNote.NoteText;
                parameters.Add(userNoteParam);

                // Add the parameters to the DbCommand object
                dbCmd.Parameters.AddRange(parameters.ToArray());

                // Execute the stored procedure
                int returnVal = sqlDB.ExecuteNonQuery(dbCmd);
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Updates the citation review record in the database corresponding to the given CitationReview object
        /// </summary>
        /// <returns></returns>
        public void UpdateCitationReviewRecord(CitationReview citationReview, ApplicationUser currentUser)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                dbCmd = sqlDB.GetStoredProcCommand("proc_UpdateCitationReview");

                List<DbParameter> parameters = new List<DbParameter>();

                // Map the fields of the citation review object to the parameters of the stored procedure
                DbParameter reviewNumParam = dbCmd.CreateParameter();
                reviewNumParam.ParameterName = "@ReviewNumber";
                reviewNumParam.DbType = DbType.Int32;
                reviewNumParam.Size = 4;
                reviewNumParam.Value = citationReview.ReviewNum;
                parameters.Add(reviewNumParam);

                DbParameter citationNumParam = dbCmd.CreateParameter();
                citationNumParam.ParameterName = "@CitationNumber";
                citationNumParam.DbType = DbType.String;
                citationNumParam.Size = 15;
                citationNumParam.Value = citationReview.CitationNum;
                parameters.Add(citationNumParam);

                DbParameter requestDtParam = dbCmd.CreateParameter();
                requestDtParam.ParameterName = "@RequestDate";
                requestDtParam.DbType = DbType.DateTime;
                requestDtParam.Size = 8;
                requestDtParam.Value = citationReview.RequestDt;
                parameters.Add(requestDtParam);

                DbParameter issueDtParam = dbCmd.CreateParameter();
                issueDtParam.ParameterName = "@CitationIssueDate";
                issueDtParam.DbType = DbType.DateTime;
                issueDtParam.Size = 8;
                issueDtParam.Value = citationReview.IssueDt;
                parameters.Add(issueDtParam);

                DbParameter recipientLNameParam = dbCmd.CreateParameter();
                recipientLNameParam.ParameterName = "@RecipientLastName";
                recipientLNameParam.DbType = DbType.String;
                recipientLNameParam.Size = 25;
                recipientLNameParam.Value = citationReview.RecipientLName;
                parameters.Add(recipientLNameParam);

                DbParameter recipientFNameParam = dbCmd.CreateParameter();
                recipientFNameParam.ParameterName = "@RecipientFirstName";
                recipientFNameParam.DbType = DbType.String;
                recipientFNameParam.Size = 25;
                recipientFNameParam.Value = citationReview.RecipientFName;
                parameters.Add(recipientFNameParam);

                DbParameter recipientMidInitialParam = dbCmd.CreateParameter();
                recipientMidInitialParam.ParameterName = "@RecipientMiddleInitial";
                recipientMidInitialParam.DbType = DbType.String;
                recipientMidInitialParam.Size = 1;
                recipientMidInitialParam.Value = citationReview.RecipientMidInitial;
                parameters.Add(recipientMidInitialParam);

                DbParameter plateNumParam = dbCmd.CreateParameter();
                plateNumParam.ParameterName = "@PlateNumber";
                plateNumParam.DbType = DbType.String;
                plateNumParam.Size = 50;
                plateNumParam.Value = citationReview.PlateNum;
                parameters.Add(plateNumParam);

                DbParameter plateStateParam = dbCmd.CreateParameter();
                plateStateParam.ParameterName = "@PlateState";
                plateStateParam.DbType = DbType.String;
                plateStateParam.Size = 2;
                plateStateParam.Value = citationReview.PlateState;
                parameters.Add(plateStateParam);

                DbParameter vehicleMakeIDParam = dbCmd.CreateParameter();
                vehicleMakeIDParam.ParameterName = "@VehicleMakeID";
                vehicleMakeIDParam.DbType = DbType.Int32;
                vehicleMakeIDParam.Size = 4;
                if (citationReview.VehicleMakeID == 0)
                    vehicleMakeIDParam.Value = DBNull.Value;
                else
                    vehicleMakeIDParam.Value = citationReview.VehicleMakeID;
                parameters.Add(vehicleMakeIDParam);

                DbParameter vehicleModelParam = dbCmd.CreateParameter();
                vehicleModelParam.ParameterName = "@VehicleModel";
                vehicleModelParam.DbType = DbType.String;
                vehicleModelParam.Size = 20;
                vehicleModelParam.Value = citationReview.VehicleModel;
                parameters.Add(vehicleModelParam);

                DbParameter citationAddrDirParam = dbCmd.CreateParameter();
                citationAddrDirParam.ParameterName = "@CitationAddressDirection";
                citationAddrDirParam.DbType = DbType.String;
                citationAddrDirParam.Size = 5;
                citationAddrDirParam.Value = citationReview.CitationAddrDir;
                parameters.Add(citationAddrDirParam);

                DbParameter citationAddrNumParam = dbCmd.CreateParameter();
                citationAddrNumParam.ParameterName = "@CitationAddressNumber";
                citationAddrNumParam.DbType = DbType.String;
                citationAddrNumParam.Size = 50;
                citationAddrNumParam.Value = citationReview.CitationAddrNum;
                parameters.Add(citationAddrNumParam);

                DbParameter citationAddrStreetParam = dbCmd.CreateParameter();
                citationAddrStreetParam.ParameterName = "@CitationAddressStreet";
                citationAddrStreetParam.DbType = DbType.String;
                citationAddrStreetParam.Size = 100;
                citationAddrStreetParam.Value = citationReview.CitationAddrStreet;
                parameters.Add(citationAddrStreetParam);

                DbParameter citationAddrStreetTypeParam = dbCmd.CreateParameter();
                citationAddrStreetTypeParam.ParameterName = "@CitationAddressType";
                citationAddrStreetTypeParam.DbType = DbType.String;
                citationAddrStreetTypeParam.Size = 50;
                citationAddrStreetTypeParam.Value = citationReview.CitationAddrStreetType;
                parameters.Add(citationAddrStreetTypeParam);

                DbParameter reviewReasonIDParam = dbCmd.CreateParameter();
                reviewReasonIDParam.ParameterName = "@ReasonID";
                reviewReasonIDParam.DbType = DbType.Int32;
                reviewReasonIDParam.Size = 4;
                if (citationReview.ReviewReasonID == 0)
                    reviewReasonIDParam.Value = DBNull.Value;
                else
                    reviewReasonIDParam.Value = citationReview.ReviewReasonID;
                parameters.Add(reviewReasonIDParam);

                DbParameter reviewReasonExpParam = dbCmd.CreateParameter();
                reviewReasonExpParam.ParameterName = "@ReasonExplanation";
                reviewReasonExpParam.DbType = DbType.String;
                reviewReasonExpParam.Size = 2000;
                reviewReasonExpParam.Value = citationReview.ReviewReasonExp;
                parameters.Add(reviewReasonExpParam);

                DbParameter physicianParam = dbCmd.CreateParameter();
                physicianParam.ParameterName = "@AttendingPhysician";
                physicianParam.DbType = DbType.String;
                physicianParam.Size = 50;
                physicianParam.Value = citationReview.Physician;
                parameters.Add(physicianParam);

                DbParameter physicianVisitDtParam = dbCmd.CreateParameter();
                physicianVisitDtParam.ParameterName = "@PhysicianVisitDate";
                physicianVisitDtParam.DbType = DbType.DateTime;
                physicianVisitDtParam.Size = 8;
                if (citationReview.PhysicianVisitDt == DateTime.MinValue)
                    physicianVisitDtParam.Value = DBNull.Value;
                else
                    physicianVisitDtParam.Value = citationReview.PhysicianVisitDt;
                parameters.Add(physicianVisitDtParam);

                DbParameter recipientAddr1Param = dbCmd.CreateParameter();
                recipientAddr1Param.ParameterName = "@RecipientAddress1";
                recipientAddr1Param.DbType = DbType.String;
                recipientAddr1Param.Size = 100;
                recipientAddr1Param.Value = citationReview.RecipientAddr1;
                parameters.Add(recipientAddr1Param);

                DbParameter recipientAddr2Param = dbCmd.CreateParameter();
                recipientAddr2Param.ParameterName = "@RecipientAddress2";
                recipientAddr2Param.DbType = DbType.String;
                recipientAddr2Param.Size = 100;
                recipientAddr2Param.Value = citationReview.RecipientAddr2;
                parameters.Add(recipientAddr2Param);

                DbParameter recipientAddrCityParam = dbCmd.CreateParameter();
                recipientAddrCityParam.ParameterName = "@RecipientAddressCity";
                recipientAddrCityParam.DbType = DbType.String;
                recipientAddrCityParam.Size = 50;
                recipientAddrCityParam.Value = citationReview.RecipientAddrCity;
                parameters.Add(recipientAddrCityParam);

                DbParameter recipientAddrStateParam = dbCmd.CreateParameter();
                recipientAddrStateParam.ParameterName = "@RecipientAddressState";
                recipientAddrStateParam.DbType = DbType.String;
                recipientAddrStateParam.Size = 2;
                recipientAddrStateParam.Value = citationReview.RecipientAddrState;
                parameters.Add(recipientAddrStateParam);

                DbParameter recipientAddrZipParam = dbCmd.CreateParameter();
                recipientAddrZipParam.ParameterName = "@RecipientAddressZip";
                recipientAddrZipParam.DbType = DbType.String;
                recipientAddrZipParam.Size = 10;
                recipientAddrZipParam.Value = citationReview.RecipientAddrZip;
                parameters.Add(recipientAddrZipParam);

                DbParameter recipientEmailAddrParam = dbCmd.CreateParameter();
                recipientEmailAddrParam.ParameterName = "@RecipientEmailAddress";
                recipientEmailAddrParam.DbType = DbType.String;
                recipientEmailAddrParam.Size = 50;
                recipientEmailAddrParam.Value = citationReview.RecipientEmailAddr;
                parameters.Add(recipientEmailAddrParam);

                DbParameter recipientHomeNumParam = dbCmd.CreateParameter();
                recipientHomeNumParam.ParameterName = "@RecipientHomePhone";
                recipientHomeNumParam.DbType = DbType.String;
                recipientHomeNumParam.Size = 15;
                recipientHomeNumParam.Value = citationReview.RecipientHomeNum;
                parameters.Add(recipientHomeNumParam);

                DbParameter recipientWorkNumParam = dbCmd.CreateParameter();
                recipientWorkNumParam.ParameterName = "@RecipientWorkPhone";
                recipientWorkNumParam.DbType = DbType.String;
                recipientWorkNumParam.Size = 15;
                recipientWorkNumParam.Value = citationReview.RecipientWorkNum;
                parameters.Add(recipientWorkNumParam);

                DbParameter recipientWorkNumExtParam = dbCmd.CreateParameter();
                recipientWorkNumExtParam.ParameterName = "@RecipientWorkExt";
                recipientWorkNumExtParam.DbType = DbType.String;
                recipientWorkNumExtParam.Size = 6;
                recipientWorkNumExtParam.Value = citationReview.RecipientWorkNumExt;
                parameters.Add(recipientWorkNumExtParam);

                DbParameter internalReceiveDtParam = dbCmd.CreateParameter();
                internalReceiveDtParam.ParameterName = "@InternalDateReceived";
                internalReceiveDtParam.DbType = DbType.DateTime;
                internalReceiveDtParam.Size = 8;
                if (citationReview.InternalReceiveDt == DateTime.MinValue)
                    internalReceiveDtParam.Value = DBNull.Value;
                else
                    internalReceiveDtParam.Value = citationReview.InternalReceiveDt;
                parameters.Add(internalReceiveDtParam);

                DbParameter internalReceivedByParam = dbCmd.CreateParameter();
                internalReceivedByParam.ParameterName = "@InternalReceivedBy";
                internalReceivedByParam.DbType = DbType.String;
                internalReceivedByParam.Size = 50;
                internalReceivedByParam.Value = citationReview.InternalReceivedBy;
                parameters.Add(internalReceivedByParam);

                DbParameter determinationParam = dbCmd.CreateParameter();
                determinationParam.ParameterName = "@DeterminationID";
                determinationParam.DbType = DbType.Int32;
                determinationParam.Size = 4;
                if (citationReview.Determination == -1)
                    determinationParam.Value = DBNull.Value;
                else
                    determinationParam.Value = citationReview.Determination;
                parameters.Add(determinationParam);

                DbParameter reviewerID1Param = dbCmd.CreateParameter();
                reviewerID1Param.ParameterName = "@ReviewedByID1";
                reviewerID1Param.DbType = DbType.Int32;
                reviewerID1Param.Size = 4;
                if (citationReview.ReviewerID1 == 0)
                    reviewerID1Param.Value = DBNull.Value;
                else
                    reviewerID1Param.Value = citationReview.ReviewerID1;
                parameters.Add(reviewerID1Param);

                DbParameter reviewerID2Param = dbCmd.CreateParameter();
                reviewerID2Param.ParameterName = "@ReviewedByID2";
                reviewerID2Param.DbType = DbType.Int32;
                reviewerID2Param.Size = 4;
                if (citationReview.ReviewerID2 == 0)
                    reviewerID2Param.Value = DBNull.Value;
                else
                    reviewerID2Param.Value = citationReview.ReviewerID2;
                parameters.Add(reviewerID2Param);

                DbParameter extReviewedByName1Param = dbCmd.CreateParameter();
                extReviewedByName1Param.ParameterName = "@ExtReviewedByName1";
                extReviewedByName1Param.DbType = DbType.String;
                extReviewedByName1Param.Size = 50;
                extReviewedByName1Param.Value = citationReview.ExtReviewerName1;
                parameters.Add(extReviewedByName1Param);

                DbParameter extReviewedByName2Param = dbCmd.CreateParameter();
                extReviewedByName2Param.ParameterName = "@ExtReviewedByName2";
                extReviewedByName2Param.DbType = DbType.String;
                extReviewedByName2Param.Size = 50;
                extReviewedByName2Param.Value = citationReview.ExtReviewerName2;
                parameters.Add(extReviewedByName2Param);

                DbParameter reviewDtParam = dbCmd.CreateParameter();
                reviewDtParam.ParameterName = "@InternalReviewDate";
                reviewDtParam.DbType = DbType.DateTime;
                reviewDtParam.Size = 8;
                if (citationReview.ReviewDt == DateTime.MinValue)
                    reviewDtParam.Value = DBNull.Value;
                else
                    reviewDtParam.Value = citationReview.ReviewDt;
                parameters.Add(reviewDtParam);

                DbParameter excusedDtParam = dbCmd.CreateParameter();
                excusedDtParam.ParameterName = "@DateExcused";
                excusedDtParam.DbType = DbType.DateTime;
                excusedDtParam.Size = 8;
                if (citationReview.ExcusedDt == DateTime.MinValue)
                    excusedDtParam.Value = DBNull.Value;
                else
                    excusedDtParam.Value = citationReview.ExcusedDt;
                parameters.Add(excusedDtParam);

                DbParameter paidDtParam = dbCmd.CreateParameter();
                paidDtParam.ParameterName = "@DatePaid";
                paidDtParam.DbType = DbType.DateTime;
                paidDtParam.Size = 8;
                if (citationReview.PaidDt == DateTime.MinValue)
                    paidDtParam.Value = DBNull.Value;
                else
                    paidDtParam.Value = citationReview.PaidDt;
                parameters.Add(paidDtParam);

                DbParameter amountPaidParam = dbCmd.CreateParameter();
                amountPaidParam.ParameterName = "@AmountPaid";
                amountPaidParam.DbType = DbType.Decimal;
                amountPaidParam.Size = 9;
                if (citationReview.AmountPaid == 0)
                    amountPaidParam.Value = DBNull.Value;
                else
                    amountPaidParam.Value = citationReview.AmountPaid;
                parameters.Add(amountPaidParam);

                DbParameter recommendedExcusedAmtParam = dbCmd.CreateParameter();
                recommendedExcusedAmtParam.ParameterName = "@AmountExcused";
                recommendedExcusedAmtParam.DbType = DbType.Decimal;
                recommendedExcusedAmtParam.Size = 9;
                if (citationReview.RecommendedExcusedAmt == 0)
                    recommendedExcusedAmtParam.Value = DBNull.Value;
                else
                    recommendedExcusedAmtParam.Value = citationReview.RecommendedExcusedAmt;
                parameters.Add(recommendedExcusedAmtParam);

                DbParameter systemNoteParam = dbCmd.CreateParameter();
                systemNoteParam.ParameterName = "@SystemNote";
                systemNoteParam.DbType = DbType.String;
                systemNoteParam.Size = 2000;
                systemNoteParam.Value = "This citation review record was updated by " + currentUser.UserName + ".";
                parameters.Add(systemNoteParam);

                // Add the parameters to the DbCommand object
                dbCmd.Parameters.AddRange(parameters.ToArray());

                // Execute the stored procedure
                int returnVal = sqlDB.ExecuteNonQuery(dbCmd);
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }

        }

        /// <summary>
        /// Returns a boolean value for whether the citation number is unique to the database
        /// </summary>
        /// <returns></returns>
        public bool CitationNumIsUnique(string citationNum)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                bool blnNumIsUnique = true;

                // Look for the citation number in the database
                string strSQL = "SELECT CitationNumber FROM CitationReviewRequest WHERE CitationNumber = '" + citationNum + "'";
                dbCmd = sqlDB.GetSqlStringCommand(strSQL);
                IDataReader drResults = sqlDB.ExecuteReader(dbCmd);

                // If the citation number was found, then it is not unique
                while (drResults.Read())
                {
                    blnNumIsUnique = false;
                }

                return blnNumIsUnique;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Returns a CitationReview object based on the given review number
        /// </summary>
        /// <returns></returns>
        public CitationReview GetCitationReview(int reviewNum)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                CitationReview citReview = new CitationReview();

                dbCmd = sqlDB.GetStoredProcCommand("proc_GetCitationReview");

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter reviewNumParam = dbCmd.CreateParameter();
                reviewNumParam.ParameterName = "@ReviewNum";
                reviewNumParam.DbType = DbType.Int32;
                reviewNumParam.Size = 4;
                reviewNumParam.Value = reviewNum;
                parameters.Add(reviewNumParam);

                dbCmd.Parameters.AddRange(parameters.ToArray());

                IDataReader procResult = sqlDB.ExecuteReader(dbCmd);

                while (procResult.Read())
                {
                    citReview.ReviewNum = reviewNum;
                    citReview.CitationNum = procResult["CitationNumber"].ToString();
                    citReview.RequestDt = Convert.ToDateTime(procResult["RequestDate"]);
                    citReview.Physician = procResult["AttendingPhysician"].ToString();
                    citReview.PhysicianVisitDt = procResult["PhysicianVisitDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(procResult["PhysicianVisitDate"]);
                    citReview.InternalReceiveDt = procResult["InternalDateReceived"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(procResult["InternalDateReceived"]);
                    citReview.InternalReceivedBy = procResult["InternalReceivedBy"].ToString();
                    citReview.Determination = procResult["DeterminationID"] == DBNull.Value ? -1 : Convert.ToInt32(procResult["DeterminationID"]);
                    citReview.ReviewerID1 = procResult["ReviewedByID1"] == DBNull.Value ? 0 : Convert.ToInt32(procResult["ReviewedByID1"]);
                    citReview.ExtReviewerName1 = procResult["ExtReviewedByName1"].ToString();
                    citReview.ReviewerID2 = procResult["ReviewedByID2"] == DBNull.Value ? 0 : Convert.ToInt32(procResult["ReviewedByID2"]);
                    citReview.ExtReviewerName2 = procResult["ExtReviewedByName2"].ToString();
                    citReview.ReviewDt = procResult["InternalReviewDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(procResult["InternalReviewDate"]);
                    citReview.IssueDt = Convert.ToDateTime(procResult["CitationIssueDate"]);
                    citReview.PlateNum = procResult["PlateNumber"].ToString();
                    citReview.PlateState = procResult["PlateState"].ToString();
                    citReview.VehicleMakeID = procResult["VehicleMakeID"] == DBNull.Value ? 0 : Convert.ToInt32(procResult["VehicleMakeID"]);
                    citReview.VehicleModel = procResult["VehicleModel"].ToString();
                    citReview.RecipientLName = procResult["RecipientLastName"].ToString();
                    citReview.RecipientFName = procResult["RecipientFirstName"].ToString();
                    citReview.RecipientMidInitial = procResult["RecipientMiddleInitial"].ToString();
                    citReview.RecipientAddr1 = procResult["RecipientAddress1"].ToString();
                    citReview.RecipientAddr2 = procResult["RecipientAddress2"].ToString();
                    citReview.RecipientAddrCity = procResult["RecipientAddressCity"].ToString();
                    citReview.RecipientAddrState = procResult["RecipientAddressState"].ToString();
                    citReview.RecipientAddrZip = procResult["RecipientAddressZip"].ToString();
                    citReview.RecipientHomeNum = procResult["RecipientHomePhone"].ToString();
                    citReview.RecipientWorkNum = procResult["RecipientWorkPhone"].ToString();
                    citReview.RecipientWorkNumExt = procResult["RecipientWorkExt"].ToString();
                    citReview.RecipientEmailAddr = procResult["RecipientEmailAddress"].ToString();
                    citReview.ExcusedDt = procResult["DateExcused"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(procResult["DateExcused"]);
                    citReview.RecommendedExcusedAmt = procResult["AmountExcused"] == DBNull.Value ? 0 : Convert.ToInt32(procResult["AmountExcused"]);
                    citReview.AmountPaid = procResult["AmountPaid"] == DBNull.Value ? 0 : Convert.ToInt32(procResult["AmountPaid"]);
                    citReview.PaidDt = procResult["DatePaid"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(procResult["DatePaid"]);
                    citReview.CitationAddrNum = procResult["CitationAddressNumber"].ToString();
                    citReview.CitationAddrDir = procResult["CitationAddressDirection"].ToString();
                    citReview.CitationAddrStreet = procResult["CitationAddressStreet"].ToString();
                    citReview.CitationAddrStreetType = procResult["CitationAddressType"].ToString();
                    citReview.ReviewReasonID = procResult["ReasonID"] == DBNull.Value ? 0 : Convert.ToInt32(procResult["ReasonID"]);
                    citReview.ReviewReasonExp = procResult["ReasonExplanation"].ToString();
                }

                return citReview;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Returns a list of Note objects based on the given review number
        /// </summary>
        /// <returns></returns>
        public List<Note> GetNotes(int reviewNum)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                List<Note> notes = new List<Note>();
                SecurityData securityData = new SecurityData();

                dbCmd = sqlDB.GetStoredProcCommand("proc_GetReviewNotes");

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter reviewNumParam = dbCmd.CreateParameter();
                reviewNumParam.ParameterName = "@ReviewNum";
                reviewNumParam.DbType = DbType.Int32;
                reviewNumParam.Size = 4;
                reviewNumParam.Value = reviewNum;
                parameters.Add(reviewNumParam);

                dbCmd.Parameters.AddRange(parameters.ToArray());

                IDataReader procResult = sqlDB.ExecuteReader(dbCmd);

                while (procResult.Read())
                {
                    Note n = new Note();
                    n.ReviewNum = reviewNum;
                    n.NoteID = Convert.ToInt32(procResult["noteID"]);
                    n.NoteByID = procResult["noteBy"] == DBNull.Value ? 0 : Convert.ToInt32(procResult["noteBy"]);
                    n.NoteDate = Convert.ToDateTime(procResult["noteDate"]);
                    n.NoteText = procResult["note"].ToString();
                    n.NoteType = procResult["noteType"].ToString();
                    if (n.NoteByID != 0)
                    {
                        ApplicationUser noteByUser = securityData.GetApplicationUserByID(procResult["noteBy"].ToString());
                        n.NoteByName = noteByUser.UserName;
                    }
                    else
                    {
                        if (n.NoteType == "User")
                        {
                            // This is a note from the original system, which did not record which user entered the notes
                            n.NoteByName = "N/A";
                        }
                    }

                    notes.Add(n);
                }

                return notes;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Inserts a new note for the specified review number into the database
        /// </summary>
        /// <returns></returns>
        public void AddNote(Note note)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;

            try
            {
                dbCmd = sqlDB.GetStoredProcCommand("proc_InsertReviewNote");

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter reviewNumberParam = dbCmd.CreateParameter();
                reviewNumberParam.ParameterName = "@ReviewNumber";
                reviewNumberParam.DbType = DbType.Int32;
                reviewNumberParam.Size = 4;
                reviewNumberParam.Value = note.ReviewNum;
                parameters.Add(reviewNumberParam);

                DbParameter userNoteParam = dbCmd.CreateParameter();
                userNoteParam.ParameterName = "@UserNote";
                userNoteParam.DbType = DbType.String;
                userNoteParam.Size = 2000;
                userNoteParam.Value = note.NoteText;
                parameters.Add(userNoteParam);

                DbParameter noteByParam = dbCmd.CreateParameter();
                noteByParam.ParameterName = "@UserNoteBy";
                noteByParam.DbType = DbType.Int32;
                noteByParam.Size = 4;
                noteByParam.Value = note.NoteByID;
                parameters.Add(noteByParam);

                // Add the parameters to the DbCommand object
                dbCmd.Parameters.AddRange(parameters.ToArray());

                // Execute the stored procedure
                int returnVal = sqlDB.ExecuteNonQuery(dbCmd);
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Updates the note in the database corresponding to the given Note obect
        /// </summary>
        /// <returns></returns>
        public void UpdateNote(Note note)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                dbCmd = sqlDB.GetStoredProcCommand("proc_UpdateReviewNote");

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter noteIDParam = dbCmd.CreateParameter();
                noteIDParam.ParameterName = "@NoteID";
                noteIDParam.DbType = DbType.Int32;
                noteIDParam.Size = 4;
                noteIDParam.Value = note.NoteID;
                parameters.Add(noteIDParam);

                DbParameter userNoteParam = dbCmd.CreateParameter();
                userNoteParam.ParameterName = "@UserNote";
                userNoteParam.DbType = DbType.String;
                userNoteParam.Size = 2000;
                userNoteParam.Value = note.NoteText;
                parameters.Add(userNoteParam);

                DbParameter noteByParam = dbCmd.CreateParameter();
                noteByParam.ParameterName = "@UserNoteBy";
                noteByParam.DbType = DbType.Int32;
                noteByParam.Size = 4;
                noteByParam.Value = note.NoteByID;
                parameters.Add(noteByParam);

                DbParameter noteDtParam = dbCmd.CreateParameter();
                noteDtParam.ParameterName = "@NoteDate";
                noteDtParam.DbType = DbType.DateTime;
                noteDtParam.Size = 8;
                noteDtParam.Value = note.NoteDate;
                parameters.Add(noteDtParam);

                // Add the parameters to the DbCommand object
                dbCmd.Parameters.AddRange(parameters.ToArray());

                // Execute the stored procedure
                int returnVal = sqlDB.ExecuteNonQuery(dbCmd);
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Deletes the note in the database corresponding to the given note object 
        /// </summary>
        /// <returns></returns>
        public void DeleteNote(Note note,  ApplicationUser currentUser)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                dbCmd = sqlDB.GetStoredProcCommand("proc_DeleteReviewNote");

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter noteIDParam = dbCmd.CreateParameter();
                noteIDParam.ParameterName = "@NoteID";
                noteIDParam.DbType = DbType.Int32;
                noteIDParam.Size = 4;
                noteIDParam.Value = note.NoteID;
                parameters.Add(noteIDParam);

                DbParameter reviewNumberParam = dbCmd.CreateParameter();
                reviewNumberParam.ParameterName = "@ReviewNumber";
                reviewNumberParam.DbType = DbType.Int32;
                reviewNumberParam.Size = 4;
                reviewNumberParam.Value = note.ReviewNum;
                parameters.Add(reviewNumberParam);

                DbParameter systemNoteParam = dbCmd.CreateParameter();
                systemNoteParam.ParameterName = "@SystemNote";
                systemNoteParam.DbType = DbType.String;
                systemNoteParam.Size = 2000;
                systemNoteParam.Value = "A user note was deleted by " + currentUser.UserName + ".";
                parameters.Add(systemNoteParam);

                // Add the parameters to the DbCommand object
                dbCmd.Parameters.AddRange(parameters.ToArray());

                // Execute the stored procedure
                int returnVal = sqlDB.ExecuteNonQuery(dbCmd);
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Returns a list of CitationReview objects using the given searchText as search criteria
        /// </summary>
        /// <returns></returns>
        public List<CitationReview> GetSearchResults(string searchText)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                List<CitationReview> citReviewList = new List<CitationReview>();

                dbCmd = sqlDB.GetStoredProcCommand("proc_GetSearchResults");

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter searchTextParam = dbCmd.CreateParameter();
                searchTextParam.ParameterName = "@SearchText";
                searchTextParam.DbType = DbType.String;
                searchTextParam.Size = 20;
                searchTextParam.Value = searchText;
                parameters.Add(searchTextParam);

                dbCmd.Parameters.AddRange(parameters.ToArray());

                IDataReader procResult = sqlDB.ExecuteReader(dbCmd);

                while (procResult.Read())
                {
                    CitationReview cr = new CitationReview();
                    cr.ReviewNum = Convert.ToInt32(procResult["ReviewNumber"]);
                    cr.CitationNum = procResult["CitationNumber"].ToString();
                    cr.RequestDt = Convert.ToDateTime(procResult["RequestDate"]);
                    cr.IssueDt = Convert.ToDateTime(procResult["CitationIssueDate"]);
                    cr.RecipientLName = procResult["RecipientLastName"].ToString();
                    cr.RecipientFName = procResult["RecipientFirstName"].ToString();
                    cr.RecipientMidInitial = procResult["RecipientMiddleInitial"].ToString();
                    cr.PlateNum = procResult["PlateNumber"].ToString();

                    citReviewList.Add(cr);
                }

                return citReviewList;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Returns a string representation of the total number of records returned from the Pending report based on the given date range
        /// </summary>
        /// <returns></returns>
        public string GetPendingRecordCount(string dtStart, string dtEnd)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            DbCommand dbCmd = null;
            try
            {
                int totalCount = 0;

                dbCmd = sqlDB.GetStoredProcCommand("proc_GetPendingRecordCount");

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter startDtParam = dbCmd.CreateParameter();
                startDtParam.ParameterName = "@StartDate";
                startDtParam.DbType = DbType.DateTime;
                startDtParam.Size = 8;
                startDtParam.Value = Convert.ToDateTime(dtStart);
                parameters.Add(startDtParam);

                DbParameter endDtParam = dbCmd.CreateParameter();
                endDtParam.ParameterName = "@EndDate";
                endDtParam.DbType = DbType.DateTime;
                endDtParam.Size = 8;
                endDtParam.Value = Convert.ToDateTime(dtEnd);
                parameters.Add(endDtParam);

                dbCmd.Parameters.AddRange(parameters.ToArray());

                IDataReader procResult = sqlDB.ExecuteReader(dbCmd);

                while (procResult.Read())
                {
                    totalCount = Convert.ToInt32(procResult["TotalCount"]);
                }

                return totalCount.ToString();
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Returns a DataView object containing the results of the Pending report based on the given date range, starting index, and page size
        /// </summary>
        /// <returns></returns>
        public DataView GetPendingRecords(string dtStart, string dtEnd, int startRecord, int pageSize)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            SqlConnection sqlConn = new SqlConnection(sqlDB.CreateConnection().ConnectionString);
            DbDataAdapter dataAdapter = new SqlDataAdapter("proc_GetPendingRecords", sqlConn);
            sqlConn.Open();

            try
            {
                SecurityData securityData = new SecurityData();

                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter startDtParam = dataAdapter.SelectCommand.CreateParameter();
                startDtParam.ParameterName = "@StartDate";
                startDtParam.DbType = DbType.DateTime;
                startDtParam.Size = 8;
                startDtParam.Value = Convert.ToDateTime(dtStart);
                parameters.Add(startDtParam);

                DbParameter endDtParam = dataAdapter.SelectCommand.CreateParameter();
                endDtParam.ParameterName = "@EndDate";
                endDtParam.DbType = DbType.DateTime;
                endDtParam.Size = 8;
                endDtParam.Value = Convert.ToDateTime(dtEnd);
                parameters.Add(endDtParam);

                dataAdapter.SelectCommand.Parameters.AddRange(parameters.ToArray());

                DataSet dataSet = new DataSet();

                // Only fill dataSet with records for the specified page
                dataAdapter.Fill(dataSet, startRecord, pageSize, "CitationReviewRequest");

                // Add columns for the Reviewer1 and Reviewer2 names
                DataColumn reviewer1Col = new DataColumn();
                reviewer1Col.DataType = System.Type.GetType("System.String");
                reviewer1Col.ColumnName = "ReviewedByName1";
                dataSet.Tables[0].Columns.Add(reviewer1Col);

                DataColumn reviewer2Col = new DataColumn();
                reviewer2Col.DataType = System.Type.GetType("System.String");
                reviewer2Col.ColumnName = "ReviewedByName2";
                dataSet.Tables[0].Columns.Add(reviewer2Col);

                // Update the reviewer columns in the dataSet with the full names of the reviewers
                string reviewerID1;
                string reviewerID2;
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    reviewerID1 = dataSet.Tables[0].Rows[i]["ReviewedByID1"].ToString();
                    reviewerID2 = dataSet.Tables[0].Rows[i]["ReviewedByID2"].ToString();

                    if (reviewerID1 == "-2")
                    {
                        dataSet.Tables[0].Rows[i]["ReviewedByName1"] = dataSet.Tables[0].Rows[i]["ExtReviewedByName1"].ToString();
                    }
                    else
                    {
                        dataSet.Tables[0].Rows[i]["ReviewedByName1"] = securityData.GetReviewerNameByID(reviewerID1);
                    }

                    if (reviewerID2 == "-2")
                    {
                        dataSet.Tables[0].Rows[i]["ReviewedByName2"] = dataSet.Tables[0].Rows[i]["ExtReviewedByName2"].ToString();
                    }
                    else
                    {
                        dataSet.Tables[0].Rows[i]["ReviewedByName2"] = securityData.GetReviewerNameByID(reviewerID2);
                    }
                }

                DataView pendingCitReviews = dataSet.Tables[0].DefaultView;

                return pendingCitReviews;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open) sqlConn.Close();
            }
        }

        /// <summary>
        /// Returns a string representation of the total number of records returned from the Court report based on the given date range
        /// </summary>
        /// <returns></returns>
        public string GetCourtRecordCount(string dtStart, string dtEnd)
        {
            //SqlDatabase sqlDB = DatabaseFactory.CreateDatabase() as SqlDatabase;

            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");

            DbCommand dbCmd = null;
            string DBConnectionString = ConfigurationManager.ConnectionStrings["ParkingReviewDB"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(DBConnectionString);
            sqlConn.Open();
            try
            {
                int totalCount = 0;

                dbCmd = sqlDB.GetStoredProcCommand("proc_GetCourtRecordCount");

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter startDtParam = dbCmd.CreateParameter();
                startDtParam.ParameterName = "@StartDate";
                startDtParam.DbType = DbType.DateTime;
                startDtParam.Size = 8;
                startDtParam.Value = Convert.ToDateTime(dtStart);
                parameters.Add(startDtParam);

                DbParameter endDtParam = dbCmd.CreateParameter();
                endDtParam.ParameterName = "@EndDate";
                endDtParam.DbType = DbType.DateTime;
                endDtParam.Size = 8;
                endDtParam.Value = Convert.ToDateTime(dtEnd);
                parameters.Add(endDtParam);

                dbCmd.Parameters.AddRange(parameters.ToArray());

                IDataReader procResult = sqlDB.ExecuteReader(dbCmd);

                while (procResult.Read())
                {
                    totalCount = Convert.ToInt32(procResult["TotalCount"]);
                }

                return totalCount.ToString();
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (dbCmd.Connection.State == ConnectionState.Open) dbCmd.Connection.Close();
            }
        }

        /// <summary>
        /// Returns a DataView object containing the results of the Court report based on the given date range, starting index, and page size
        /// </summary>
        /// <returns></returns>
        public DataView GetCourtRecords(string dtStart, string dtEnd, int startRecord, int pageSize)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database sqlDB = factory.Create("ParkingReviewDB");
            SqlConnection sqlConn = new SqlConnection(sqlDB.CreateConnection().ConnectionString);
            DbDataAdapter dataAdapter = new SqlDataAdapter("proc_GetCourtRecords", sqlConn);
            sqlConn.Open();

            try
            {
                SecurityData securityData = new SecurityData();

                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                List<DbParameter> parameters = new List<DbParameter>();

                DbParameter startDtParam = dataAdapter.SelectCommand.CreateParameter();
                startDtParam.ParameterName = "@StartDate";
                startDtParam.DbType = DbType.DateTime;
                startDtParam.Size = 8;
                startDtParam.Value = Convert.ToDateTime(dtStart);
                parameters.Add(startDtParam);

                DbParameter endDtParam = dataAdapter.SelectCommand.CreateParameter();
                endDtParam.ParameterName = "@EndDate";
                endDtParam.DbType = DbType.DateTime;
                endDtParam.Size = 8;
                endDtParam.Value = Convert.ToDateTime(dtEnd);
                parameters.Add(endDtParam);

                dataAdapter.SelectCommand.Parameters.AddRange(parameters.ToArray());

                DataSet dataSet = new DataSet();

                // Only fill dataSet with records for the specified page
                dataAdapter.Fill(dataSet, startRecord, pageSize, "CitationReviewRequest");

                DataView pendingCitReviews = dataSet.Tables[0].DefaultView;

                return pendingCitReviews;
            }
            catch (Exception ex)
            {
                Type t = this.GetType();
                ExceptionLogger log = new ExceptionLogger(ex);
                throw ex;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open) sqlConn.Close();
            }
        }

        #endregion
        //Additional functionality added for external site and new ado.net approach 
        public Database GetDB()
        {//begin function
            Database TempDb;

            //get the default database from web.config
            TempDb = DatabaseFactory.CreateDatabase();
            //return that database object
            return TempDb;
        }//end function


        public int TimeofDayIdGet(string ItemDesc)
        {//begin function
            Database TempDB;
            DbCommand TempCmd;
            int RetVal = 0;


            try
            {//begin try
                //put the database object in a var
                TempDB = this.GetDB();
                //create the command object for the stored proc
                TempCmd = TempDB.GetStoredProcCommand("TimeofDayIdGet");
                TempDB.AddInParameter(TempCmd, "@TimeofDay", DbType.String, ItemDesc);
                RetVal = Int32.Parse(TempDB.ExecuteScalar(TempCmd).ToString());

                return RetVal;

            }//end try
            finally
            {//begin finally
                //clean up
                TempDB = null;
                TempCmd = null;
            }//end finally


        }//end function
    }
}
