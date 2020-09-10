using System;
using System.Collections.Generic;

namespace ParkingCitationReviewApp.Models
{
    public partial class DeterminationIndex
    {
        public DeterminationIndex()
        {
            CitationReviewRequest = new HashSet<CitationReviewRequest>();
        }

        public string Determination { get; set; }
        public decimal DeterminationId { get; set; }
        public string ActiveYn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }

        public virtual ICollection<CitationReviewRequest> CitationReviewRequest { get; set; }
    }
}
