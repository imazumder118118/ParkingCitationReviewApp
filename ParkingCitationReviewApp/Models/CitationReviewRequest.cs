using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParkingCitationReviewApp.Models
{
    public partial class CitationReviewRequest
    {
        public CitationReviewRequest()
        {
            ReviewNotes = new HashSet<ReviewNotes>();
        }

        public decimal ReviewNumber { get; set; }
        [Required(ErrorMessage ="Citation No is reqired field")]
        public string CitationNumber { get; set; }
        [Required(ErrorMessage = "Request Date is required field")]
        [Display(Name = "Citation Issue Date")]
        [DataType(DataType.Date)]
        public DateTime? RequestDate { get; set; }
        public string AttendingPhysician { get; set; }
        public string RequestorName { get; set; }
        [Required(ErrorMessage = "Signature  is required field")]
        public string RecipientSign { get; set; }
        [Required(ErrorMessage = "Signature  Date is required field")]
        public DateTime? SignDate { get; set; }
        public DateTime? PhysicianVisitDate { get; set; }
        public DateTime? InternalDateReceived { get; set; }
        public string InternalReceivedBy { get; set; }
        public decimal? DeterminationId { get; set; }
        public decimal? ReviewedById1 { get; set; }
        public decimal? ReviewedById2 { get; set; }
        public DateTime? InternalReviewDate { get; set; }
        [Required(ErrorMessage = "Citation Issue Date is required field")]
        [Display(Name = "Citation Issue Date")]
        [DataType(DataType.Date)]
        public DateTime? CitationIssueDate { get; set; }
        [Required(ErrorMessage = "Plate No is required field")]
        public string PlateNumber { get; set; }
        public string PlateState { get; set; }
        public decimal? VehicleMakeId { get; set; }
        public string VehicleModel { get; set; }
        [Required(ErrorMessage = "Last Name is required field")]
        public string RecipientLastName { get; set; }
        [Required(ErrorMessage = "First Name is required field")]
        public string RecipientFirstName { get; set; }
        [StringLength(1, ErrorMessage = "Middle initial cannot be more than one character")]
        public string RecipientMiddleInitial { get; set; }
        [Required(ErrorMessage = "Address is required field")]
        public string RecipientAddress1 { get; set; }
        public string RecipientAddress2 { get; set; }
        [Required(ErrorMessage = "City is required field")]
        public string RecipientAddressCity { get; set; }
        [Required (ErrorMessage = "State is required field")]
        public string RecipientAddressState { get; set; }
        [StringLength(5, ErrorMessage = "Zipcode is not more than 5 digits")]
        [Required(ErrorMessage = "Zip Code is required field")]
        public string RecipientAddressZip { get; set; }
        
        public string RecipientHomePhone { get; set; }
        public string RecipientWorkPhone { get; set; }
        public string RecipientWorkExt { get; set; }
        [Required(ErrorMessage ="Email id required field")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",ErrorMessage ="Valid email id is required.")]
        public string RecipientEmailAddress { get; set; }
        public DateTime? DateExcused { get; set; }
        public decimal? AmountExcused { get; set; }
        public decimal? AmountPaid { get; set; }
        public DateTime? DatePaid { get; set; }
        public string CitationAddressNumber { get; set; }
        public string CitationAddressDirection { get; set; }
        public string CitationAddressStreet { get; set; }
        public string CitationAddressType { get; set; }
        [Required(ErrorMessage ="Select the reason is required")]
        public decimal? ReasonId { get; set; }
        [StringLength(1000,ErrorMessage = "Reason explanation  must not be more than 1000 characters long.")]
        public string ReasonExplanation { get; set; }
        public string DocumentPath { get; set; }
        public string ExtReviewedByName1 { get; set; }
        public string ExtReviewedByName2 { get; set; }

        public virtual DeterminationIndex Determination { get; set; }
        public virtual ReviewReasonIndex Reason { get; set; }
        public virtual VehicleMakeIndex VehicleMake { get; set; }
        public virtual ICollection<ReviewNotes> ReviewNotes { get; set; }
    }
}
