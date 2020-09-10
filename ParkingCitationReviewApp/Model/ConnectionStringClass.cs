using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ParkingCitationReviewApp.Model
{
    public class ConnectionStringClass : DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options) : base(options)
        {

        }
        public DbSet<ReviewReasonIndex> ReviewReasonIndex { get; set; }
        public DbSet<CitationReviewRequest> CitationReviewRequest { get; set; }
        //public DbSet<CitationReviewVM> CitationReviewVM { get; set; }
    }
}