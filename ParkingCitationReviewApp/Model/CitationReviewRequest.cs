
using System;
using System.ComponentModel.DataAnnotations;


namespace ParkingCitationReviewApp.Model
{
    /// <summary>
    /// Custom class representing an citation review
    /// </summary>
    
    public class CitationReviewRequest
    {
        [Key]
        public int ReviewNumber { get; set; }

        /// <summary>
        ///  Private member field containing citation number
        /// </summary>
       
        public string CitationNumber { get; set; }

        /// <summary>
        ///  Private member field containing date of request
        /// </summary>
        public DateTime? RequestDate { get; set; }

        /// <summary>
        ///  Private member field containing date the citation was issued
        /// </summary>
        public DateTime? CitationIssueDate { get; set; }

        /// <summary>
        ///  Private member field containing recipient's last name
        /// </summary>
        public string RecipientLastName { get; set; }

        /// <summary>
        ///  Private member field containing recipient's first name
        /// </summary>
        public string RecipientFirstName { get; set; }

        /// <summary>
        ///  Private member field containing recipient's middle initial
        /// </summary>
        public string RecipientMiddleInitial { get; set; }

        /// <summary>
        ///  Private member field containing line 1 of recipient's address
        /// </summary>
        public string RecipientAddress1 { get; set; }

        /// <summary>
        ///  Private member field containing line 2 of recipient's address
        /// </summary>
        public string RecipientAddress2 { get; set; }

        /// <summary>
        ///  Private member field containing city of recipient's address
        /// </summary>
        public string RecipientAddressCity { get; set; }

        /// <summary>
        ///  Private member field containing state of recipient's address
        /// </summary>
        public string RecipientAddressState { get; set; }

        /// <summary>
        ///  Private member field containing zip code of recipient's address
        /// </summary>
        public string RecipientAddressZip { get; set; }

        /// <summary>
        ///  Private member field containing recipient's email address
        /// </summary>
        public string RecipientEmailAddress { get; set; }

        /// <summary>
        ///  Private member field containing recipient's home phone number
        /// </summary>
        public string RecipientHomePhone { get; set; }

        /// <summary>
        ///  Private member field containing recipient's work phone number
        /// </summary>
        public string RecipientWorkPhone { get; set; }

        /// <summary>
        ///  Private member field containing recipient's work phone number extension
        /// </summary>
        public string RecipientWorkExt { get; set; }

        /// <summary>
        ///  Private member field containing vehicle plate number
        /// </summary>
        public string PlateNumber { get; set; }

        /// <summary>
        ///  Private member field containing the state of the vehicle plates
        /// </summary>
        public string PlateState { get; set; }

        /// <summary>
        ///  Private member field containing vehicle make ID
        /// </summary>
        public decimal? VehicleMakeID { get; set; }

        /// <summary>
        ///  Private member field containing vehicle model
        /// </summary>
        public string VehicleModel { get; set; }

        /// <summary>
        ///  Private member field containing citation address number
        /// </summary>
        public string CitationAddressNumber { get; set; }

        /// <summary>
        ///  Private member field containing citation address street direction
        /// </summary>
        public string CitationAddressDirection { get; set; }

        /// <summary>
        ///  Private member field containing citation address street name
        /// </summary>
        public string CitationAddressStreet { get; set; }

        /// <summary>
        ///  Private member field containing citation address street type
        /// </summary>
        public string CitationAddressType { get; set; }

        /// <summary>
        ///  Private member field containing ID of review request reason
        /// </summary>
        public decimal? ReasonID { get; set; }

        /// <summary>
        ///  Private member field containing explanation of review request reason
        /// </summary>
        public string ReasonExplanation { get; set; }

        /// <summary>
        ///  Private member field containing name of attending physician
        /// </summary>
        public string AttendingPhysician { get; set; }

        /// <summary>
        ///  Private member field containing date of visit to the physician
        /// </summary>
        public DateTime? PhysicianVisitDate { get; set; }

        /// <summary>
        ///  Private member field containing date the review request was received internally
        /// </summary>
        public DateTime? InternalDateReceived { get; set; }

        /// <summary>
        ///  Private member field containing name of person who received review request internally
        /// </summary>
        public string InternalReceivedBy { get; set; }

        /// <summary>
        ///  Private member field containing ID of the determination of the citation review
        /// </summary>
        public decimal? DeterminationID { get; set; }

        /// <summary>
        ///  Private member field containing ID of the first citation reviewer
        /// </summary>
        public int ReviewedByID1 { get; set; }

        /// <summary>
        ///  Private member field containing ID of the second citation reviewer
        /// </summary>
        public int ReviewedByID2 { get; set; }

        /// <summary>
        ///  Private member field containing name of the first citation reviewer
        /// </summary>
        public string ExtReviewedByName1 { get; set; }

        /// <summary>
        ///  Private member field containing name of the second citation reviewer
        /// </summary>
        public string ExtReviewedByName2 { get; set; }

        /// <summary>
        ///  Private member field containing date of the internal citation review
        /// </summary>
        public DateTime? InternalReviewDate { get; set; }

        /// <summary>
        ///  Private member field containing date citation was excused
        /// </summary>
        public DateTime? DateExcused { get; set; }

        /// <summary>
        ///  Private member field containing date citation was paid
        /// </summary>
        public DateTime? DatePaid { get; set; }

        /// <summary>
        ///  Private member field containing dollar amount paid for citation
        /// </summary>
        public decimal AmountPaid { get; set; }

        /// <summary>
        ///  Private member field containing dollar amount recommended for excusal
        /// </summary>
        public decimal AmountExcused { get; set; }



    }
}
