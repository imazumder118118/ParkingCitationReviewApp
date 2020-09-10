// <copyright file="CitationReview.cs" company="City of Richmond">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Saerghe Parker</author>
// <email>saerghe.parker@richmondgov.com</email>
// <date>2008-11-03</date>
// <summary>Definition of CitationReview Class</summary>

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace ParkingCitationReviews.EntityObjects
{
    /// <summary>
    /// Custom class representing an citation review
    /// </summary>
    public class CitationReview
    {
        /// <summary>
        ///  Private member field containing review number
        /// </summary>
        private int reviewNum;

        /// <summary>
        ///  Private member field containing citation number
        /// </summary>
        private string citationNum;

        /// <summary>
        ///  Private member field containing date of request
        /// </summary>
        private DateTime requestDt;

        /// <summary>
        ///  Private member field containing date the citation was issued
        /// </summary>
        private DateTime issueDt;

        /// <summary>
        ///  Private member field containing recipient's last name
        /// </summary>
        private string recipientLName;

        /// <summary>
        ///  Private member field containing recipient's first name
        /// </summary>
        private string recipientFName;

        /// <summary>
        ///  Private member field containing recipient's middle initial
        /// </summary>
        private string recipientMidInitial;

        /// <summary>
        ///  Private member field containing line 1 of recipient's address
        /// </summary>
        private string recipientAddr1;

        /// <summary>
        ///  Private member field containing line 2 of recipient's address
        /// </summary>
        private string recipientAddr2;

        /// <summary>
        ///  Private member field containing city of recipient's address
        /// </summary>
        private string recipientAddrCity;

        /// <summary>
        ///  Private member field containing state of recipient's address
        /// </summary>
        private string recipientAddrState;

        /// <summary>
        ///  Private member field containing zip code of recipient's address
        /// </summary>
        private string recipientAddrZip;

        /// <summary>
        ///  Private member field containing recipient's email address
        /// </summary>
        private string recipientEmailAddr;

        /// <summary>
        ///  Private member field containing recipient's home phone number
        /// </summary>
        private string recipientHomeNum;

        /// <summary>
        ///  Private member field containing recipient's work phone number
        /// </summary>
        private string recipientWorkNum;

        /// <summary>
        ///  Private member field containing recipient's work phone number extension
        /// </summary>
        private string recipientWorkNumExt;

        /// <summary>
        ///  Private member field containing vehicle plate number
        /// </summary>
        private string plateNum;

        /// <summary>
        ///  Private member field containing the state of the vehicle plates
        /// </summary>
        private string plateState;

        /// <summary>
        ///  Private member field containing vehicle make ID
        /// </summary>
        private int vehicleMakeID;

        /// <summary>
        ///  Private member field containing vehicle model
        /// </summary>
        private string vehicleModel;

        /// <summary>
        ///  Private member field containing citation address number
        /// </summary>
        private string citationAddrNum;

        /// <summary>
        ///  Private member field containing citation address street direction
        /// </summary>
        private string citationAddrDir;

        /// <summary>
        ///  Private member field containing citation address street name
        /// </summary>
        private string citationAddrStreet;

        /// <summary>
        ///  Private member field containing citation address street type
        /// </summary>
        private string citationAddrStreetType;

        /// <summary>
        ///  Private member field containing ID of review request reason
        /// </summary>
        private int reviewReasonID;

        /// <summary>
        ///  Private member field containing explanation of review request reason
        /// </summary>
        private string reviewReasonExp;

        /// <summary>
        ///  Private member field containing name of attending physician
        /// </summary>
        private string physician;

        /// <summary>
        ///  Private member field containing date of visit to the physician
        /// </summary>
        private DateTime physicianVisitDt;

        /// <summary>
        ///  Private member field containing date the review request was received internally
        /// </summary>
        private DateTime internalReceiveDt;

        /// <summary>
        ///  Private member field containing name of person who received review request internally
        /// </summary>
        private string internalReceivedBy;

        /// <summary>
        ///  Private member field containing ID of the determination of the citation review
        /// </summary>
        private int determination;

        /// <summary>
        ///  Private member field containing ID of the first citation reviewer
        /// </summary>
        private int reviewerID1;

        /// <summary>
        ///  Private member field containing ID of the second citation reviewer
        /// </summary>
        private int reviewerID2;

        /// <summary>
        ///  Private member field containing name of the first citation reviewer
        /// </summary>
        private string extReviewerName1;

        /// <summary>
        ///  Private member field containing name of the second citation reviewer
        /// </summary>
        private string extReviewerName2;

        /// <summary>
        ///  Private member field containing date of the internal citation review
        /// </summary>
        private DateTime reviewDt;

        /// <summary>
        ///  Private member field containing date citation was excused
        /// </summary>
        private DateTime excusedDt;

        /// <summary>
        ///  Private member field containing date citation was paid
        /// </summary>
        private DateTime paidDt;

        /// <summary>
        ///  Private member field containing dollar amount paid for citation
        /// </summary>
        private decimal amountPaid;

        /// <summary>
        ///  Private member field containing dollar amount recommended for excusal
        /// </summary>
        private decimal recommendedExcusedAmt;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the CitationReview class with no input parameters
        /// </summary>
        public CitationReview()
        {
        }

        /// <summary>
        ///  Gets or sets the value for review number
        /// </summary>
        public int ReviewNum
        {
            get
            {
                return this.reviewNum;
            }

            set
            {
                this.reviewNum = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for citation number
        /// </summary>
        public string CitationNum
        {
            get
            {
                return this.citationNum;
            }

            set
            {
                this.citationNum = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for date of request
        /// </summary>
        public DateTime RequestDt
        {
            get
            {
                return this.requestDt;
            }

            set
            {
                this.requestDt = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for date the citation was issued
        /// </summary>
        public DateTime IssueDt
        {
            get
            {
                return this.issueDt;
            }

            set
            {
                this.issueDt = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for recipient's last name
        /// </summary>
        public string RecipientLName
        {
            get
            {
                return this.recipientLName;
            }

            set
            {
                this.recipientLName = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for recipient's first name
        /// </summary>
        public string RecipientFName
        {
            get
            {
                return this.recipientFName;
            }

            set
            {
                this.recipientFName = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for recipient's middle initial
        /// </summary>
        public string RecipientMidInitial
        {
            get
            {
                return this.recipientMidInitial;
            }

            set
            {
                this.recipientMidInitial = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for line 1 of recipient's address
        /// </summary>
        public string RecipientAddr1
        {
            get
            {
                return this.recipientAddr1;
            }

            set
            {
                this.recipientAddr1 = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for line 2 of recipient's address
        /// </summary>
        public string RecipientAddr2
        {
            get
            {
                return this.recipientAddr2;
            }

            set
            {
                this.recipientAddr2 = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for city of recipient's address
        /// </summary>
        public string RecipientAddrCity
        {
            get
            {
                return this.recipientAddrCity;
            }

            set
            {
                this.recipientAddrCity = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for state of recipient's address
        /// </summary>
        public string RecipientAddrState
        {
            get
            {
                return this.recipientAddrState;
            }

            set
            {
                this.recipientAddrState = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for zip code of recipient's address
        /// </summary>
        public string RecipientAddrZip
        {
            get
            {
                return this.recipientAddrZip;
            }

            set
            {
                this.recipientAddrZip = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for recipient's email address
        /// </summary>
        public string RecipientEmailAddr
        {
            get
            {
                return this.recipientEmailAddr;
            }

            set
            {
                this.recipientEmailAddr = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for recipient's home phone number
        /// </summary>
        public string RecipientHomeNum
        {
            get
            {
                return this.recipientHomeNum;
            }

            set
            {
                this.recipientHomeNum = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for recipient's work phone number
        /// </summary>
        public string RecipientWorkNum
        {
            get
            {
                return this.recipientWorkNum;
            }

            set
            {
                this.recipientWorkNum = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for recipient's work phone number extension
        /// </summary>
        public string RecipientWorkNumExt
        {
            get
            {
                return this.recipientWorkNumExt;
            }

            set
            {
                this.recipientWorkNumExt = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for vehicle plate number
        /// </summary>
        public string PlateNum
        {
            get
            {
                return this.plateNum;
            }

            set
            {
                this.plateNum = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for the state of the vehicle plates
        /// </summary>
        public string PlateState
        {
            get
            {
                return this.plateState;
            }

            set
            {
                this.plateState = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for vehicle make ID
        /// </summary>
        public int VehicleMakeID
        {
            get
            {
                return this.vehicleMakeID;
            }

            set
            {
                this.vehicleMakeID = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for vehicle model
        /// </summary>
        public string VehicleModel
        {
            get
            {
                return this.vehicleModel;
            }

            set
            {
                this.vehicleModel = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for citation address number
        /// </summary>
        public string CitationAddrNum
        {
            get
            {
                return this.citationAddrNum;
            }

            set
            {
                this.citationAddrNum = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for citation address street direction
        /// </summary>
        public string CitationAddrDir
        {
            get
            {
                return this.citationAddrDir;
            }

            set
            {
                this.citationAddrDir = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for citation address street name
        /// </summary>
        public string CitationAddrStreet
        {
            get
            {
                return this.citationAddrStreet;
            }

            set
            {
                this.citationAddrStreet = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for citation address street type
        /// </summary>
        public string CitationAddrStreetType
        {
            get
            {
                return this.citationAddrStreetType;
            }

            set
            {
                this.citationAddrStreetType = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for ID of review request reason
        /// </summary>
        public int ReviewReasonID
        {
            get
            {
                return this.reviewReasonID;
            }

            set
            {
                this.reviewReasonID = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for explanation of review request reason
        /// </summary>
        public string ReviewReasonExp
        {
            get
            {
                return this.reviewReasonExp;
            }

            set
            {
                this.reviewReasonExp = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for name of attending physician
        /// </summary>
        public string Physician
        {
            get
            {
                return this.physician;
            }

            set
            {
                this.physician = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for date of visit to the physician
        /// </summary>
        public DateTime PhysicianVisitDt
        {
            get
            {
                return this.physicianVisitDt;
            }

            set
            {
                this.physicianVisitDt = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for date the review request was received internally
        /// </summary>
        public DateTime InternalReceiveDt
        {
            get
            {
                return this.internalReceiveDt;
            }

            set
            {
                this.internalReceiveDt = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for name of person who received review request internally
        /// </summary>
        public string InternalReceivedBy
        {
            get
            {
                return this.internalReceivedBy;
            }

            set
            {
                this.internalReceivedBy = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for ID of the determination of the citation review
        /// </summary>
        public int Determination
        {
            get
            {
                return this.determination;
            }

            set
            {
                this.determination = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for ID of the first citation reviewer
        /// </summary>
        public int ReviewerID1
        {
            get
            {
                return this.reviewerID1;
            }

            set
            {
                this.reviewerID1 = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for ID of the second citation reviewer
        /// </summary>
        public int ReviewerID2
        {
            get
            {
                return this.reviewerID2;
            }

            set
            {
                this.reviewerID2 = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for name of the first citation reviewer
        /// </summary>
        public string ExtReviewerName1
        {
            get
            {
                return this.extReviewerName1;
            }

            set
            {
                this.extReviewerName1 = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for name of the first citation reviewer
        /// </summary>
        public string ExtReviewerName2
        {
            get
            {
                return this.extReviewerName2;
            }

            set
            {
                this.extReviewerName2 = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for date of the internal citation review
        /// </summary>
        public DateTime ReviewDt
        {
            get
            {
                return this.reviewDt;
            }

            set
            {
                this.reviewDt = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for date citation was excused
        /// </summary>
        public DateTime ExcusedDt
        {
            get
            {
                return this.excusedDt;
            }

            set
            {
                this.excusedDt = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for date citation was paid
        /// </summary>
        public DateTime PaidDt
        {
            get
            {
                return this.paidDt;
            }

            set
            {
                this.paidDt = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for dollar amount paid for citation
        /// </summary>
        public decimal AmountPaid
        {
            get
            {
                return this.amountPaid;
            }

            set
            {
                this.amountPaid = value;
            }
        }

        /// <summary>
        ///  Gets or sets the value for dollar amount recommended for excusal
        /// </summary>
        public decimal RecommendedExcusedAmt
        {
            get
            {
                return this.recommendedExcusedAmt;
            }

            set
            {
                this.recommendedExcusedAmt = value;
            }
        }

        #endregion
    }
}
