using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ParkingCitationReviewApp.Model
{
    public class ReviewReasonIndex
    {
        [Key]
        public decimal ReasonID { get; set; }
        public string ReasonDescription { get; set; }
    }
}
