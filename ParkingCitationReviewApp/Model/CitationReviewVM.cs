using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;

namespace ParkingCitationReviewApp.Model
{
    public class CitationReviewVM
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
        public DateTime RequestDate { get; set; }

        /// <summary>
        ///  Private member field containing date the citation was issued
        /// </summary>
        public DateTime CitationIssueDate { get; set; }

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
        ///  Private member field containing ID of review request reason
        /// </summary>
        public int ReasonID { get; set; }

        /// <summary>
        ///  Private member field containing explanation of review request reason
        /// </summary>
        public string ReasonExplanation { get; set; }

        public string InternalReceivedBy { get; set; }

    }
}
