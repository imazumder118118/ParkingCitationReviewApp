using System;
using System.Collections.Generic;

namespace ParkingCitationReviewApp.Models
{
    public partial class ReviewReasonIndex
    {
        public ReviewReasonIndex()
        {
            CitationReviewRequest = new HashSet<CitationReviewRequest>();
        }

        public string ReasonDescription { get; set; }
        public decimal ReasonId { get; set; }
        public string ActiveYn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }

        public virtual ICollection<CitationReviewRequest> CitationReviewRequest { get; set; }
    }
}
