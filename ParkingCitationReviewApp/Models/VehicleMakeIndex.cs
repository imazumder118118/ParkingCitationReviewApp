using System;
using System.Collections.Generic;

namespace ParkingCitationReviewApp.Models
{
    public partial class VehicleMakeIndex
    {
        public VehicleMakeIndex()
        {
            CitationReviewRequest = new HashSet<CitationReviewRequest>();
        }

        public string VehicleMake { get; set; }
        public decimal VehicleMakeId { get; set; }
        public string ActiveYn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }

        public virtual ICollection<CitationReviewRequest> CitationReviewRequest { get; set; }
    }
}
