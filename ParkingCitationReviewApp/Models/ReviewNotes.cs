using System;
using System.Collections.Generic;

namespace ParkingCitationReviewApp.Models
{
    public partial class ReviewNotes
    {
        public int NoteId { get; set; }
        public decimal ReviewNumber { get; set; }
        public int? NoteBy { get; set; }
        public DateTime NoteDate { get; set; }
        public string Note { get; set; }
        public string NoteType { get; set; }

        public virtual CitationReviewRequest ReviewNumberNavigation { get; set; }
    }
}
