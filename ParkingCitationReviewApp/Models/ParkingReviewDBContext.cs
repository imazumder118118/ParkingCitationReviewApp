using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ParkingCitationReviewApp.Models
{
    public partial class ParkingReviewDBContext : DbContext
    {
        public ParkingReviewDBContext()
        {
        }

        public ParkingReviewDBContext(DbContextOptions<ParkingReviewDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CitationReviewRequest> CitationReviewRequest { get; set; }
        public virtual DbSet<DeterminationIndex> DeterminationIndex { get; set; }
        public virtual DbSet<ReviewNotes> ReviewNotes { get; set; }
        public virtual DbSet<ReviewReasonIndex> ReviewReasonIndex { get; set; }
        public virtual DbSet<VehicleMakeIndex> VehicleMakeIndex { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DIT-SQL1603-Dv;pooling=true;Max Pool Size=6;Initial Catalog=ParkingReviewDB; User ID=ParkCitRevApp;Password=!!test99");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "ParkCitRevApp");

            modelBuilder.Entity<CitationReviewRequest>(entity =>
            {
                entity.HasKey(e => e.ReviewNumber);

                entity.ToTable("CitationReviewRequest", "dbo");

                entity.HasIndex(e => e.CitationNumber)
                    .HasName("CitationNum_Unique")
                    .IsUnique();

                entity.Property(e => e.ReviewNumber)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AmountExcused).HasColumnType("money");

                entity.Property(e => e.AmountPaid).HasColumnType("money");

                entity.Property(e => e.RequestorName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientSign)
                   .HasMaxLength(255)
                   .IsUnicode(false);
                

                entity.Property(e => e.AttendingPhysician)
                   .HasMaxLength(50)
                   .IsUnicode(false);

                entity.Property(e => e.CitationAddressDirection)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CitationAddressNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CitationAddressStreet)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CitationAddressType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CitationIssueDate).HasColumnType("datetime");

                entity.Property(e => e.SignDate).HasColumnType("datetime");
                

                entity.Property(e => e.CitationNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateExcused).HasColumnType("datetime");

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.DeterminationId)
                    .HasColumnName("DeterminationID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExtReviewedByName1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtReviewedByName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InternalDateReceived).HasColumnType("datetime");

                entity.Property(e => e.InternalReceivedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InternalReviewDate).HasColumnType("datetime");

                entity.Property(e => e.PhysicianVisitDate).HasColumnType("datetime");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlateState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonExplanation)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentPath)
                   .HasMaxLength(2000)
                   .IsUnicode(false);

                entity.Property(e => e.ReasonId)
                    .HasColumnName("ReasonID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecipientAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientAddressCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientAddressState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientAddressZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientEmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientFirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientHomePhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientLastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientMiddleInitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecipientWorkExt)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientWorkPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.ReviewedById1)
                    .HasColumnName("ReviewedByID1")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReviewedById2)
                    .HasColumnName("ReviewedByID2")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VehicleMakeId)
                    .HasColumnName("VehicleMakeID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VehicleModel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Determination)
                    .WithMany(p => p.CitationReviewRequest)
                    .HasForeignKey(d => d.DeterminationId)
                    .HasConstraintName("FK_DeterminationID");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.CitationReviewRequest)
                    .HasForeignKey(d => d.ReasonId)
                    .HasConstraintName("FK_ReasonID");

                entity.HasOne(d => d.VehicleMake)
                    .WithMany(p => p.CitationReviewRequest)
                    .HasForeignKey(d => d.VehicleMakeId)
                    .HasConstraintName("FK_VehicleMakeID");
            });

            modelBuilder.Entity<DeterminationIndex>(entity =>
            {
                entity.HasKey(e => e.DeterminationId);

                entity.ToTable("DeterminationIndex", "dbo");

                entity.Property(e => e.DeterminationId)
                    .HasColumnName("DeterminationID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ActiveYn)
                    .IsRequired()
                    .HasColumnName("ActiveYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Determination)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReviewNotes>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("ReviewNotes", "dbo");

                entity.Property(e => e.NoteId).HasColumnName("noteID");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasMaxLength(2000);

                entity.Property(e => e.NoteBy).HasColumnName("noteBy");

                entity.Property(e => e.NoteDate)
                    .HasColumnName("noteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoteType)
                    .IsRequired()
                    .HasColumnName("noteType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewNumber).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.ReviewNumberNavigation)
                    .WithMany(p => p.ReviewNotes)
                    .HasForeignKey(d => d.ReviewNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReviewNumber");
            });

            modelBuilder.Entity<ReviewReasonIndex>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("ReviewReasonIndex", "dbo");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("ReasonID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActiveYn)
                    .IsRequired()
                    .HasColumnName("ActiveYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReasonDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleMakeIndex>(entity =>
            {
                entity.HasKey(e => e.VehicleMakeId);

                entity.ToTable("VehicleMakeIndex", "dbo");

                entity.Property(e => e.VehicleMakeId)
                    .HasColumnName("VehicleMakeID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActiveYn)
                    .IsRequired()
                    .HasColumnName("ActiveYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.VehicleMake)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
