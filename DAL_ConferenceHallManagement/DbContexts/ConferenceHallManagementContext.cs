using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.AppDbModels;

namespace DAL_ConferenceHallManagement.DbContexts;

public partial class ConferenceHallManagementContext : DbContext
{
    public ConferenceHallManagementContext()
    {
    }

    public ConferenceHallManagementContext(DbContextOptions<ConferenceHallManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ConferenceHall> ConferenceHalls { get; set; }

    public virtual DbSet<ConferenceHallBooking> ConferenceHallBookings { get; set; }

    public virtual DbSet<ConferenceHallBookingSession> ConferenceHallBookingSessions { get; set; }

    public virtual DbSet<ConferenceHallSession> ConferenceHallSessions { get; set; }

    public virtual DbSet<MasterBookingStatusCode> MasterBookingStatusCodes { get; set; }

    public virtual DbSet<MasterRoomType> MasterRoomTypes { get; set; }

    public virtual DbSet<TempEmployeeRole> TempEmployeeRoles { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ConferenceHall>(entity =>
        {
            entity.HasKey(e => e.HallId);

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedFrom).HasMaxLength(50);
            entity.Property(e => e.Floor).HasMaxLength(50);
            entity.Property(e => e.HallNameEn).HasMaxLength(200);
            entity.Property(e => e.HallNameHi).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
            entity.Property(e => e.IsApprovalRequired).HasDefaultValue(false);
        });

        modelBuilder.Entity<ConferenceHallBooking>(entity =>
        {
            entity.HasKey(e => e.BookingId);

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedFrom).HasMaxLength(50);
            entity.Property(e => e.ProgramName).HasMaxLength(500);
            entity.Property(e => e.Remarks)
                .HasMaxLength(2000)
                .HasDefaultValue("");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);

            entity.HasOne(d => d.Hall).WithMany(p => p.ConferenceHallBookings)
                .HasForeignKey(d => d.HallId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConferenceHallBookings_ConferenceHalls");

            entity.HasOne(d => d.RoomType).WithMany(p => p.ConferenceHallBookings)
                .HasForeignKey(d => d.RoomTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConferenceHallBookings_MasterRoomTypes");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.ConferenceHallBookings)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConferenceHallBookings_MasterBookingStatusCodes");
        });

        modelBuilder.Entity<ConferenceHallBookingSession>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedFrom).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);

            entity.HasOne(d => d.Booking).WithMany(p => p.ConferenceHallBookingSessions)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConferenceHallBookingSessions_ConferenceHallBookings");

            entity.HasOne(d => d.Hall).WithMany(p => p.ConferenceHallBookingSessions)
                .HasForeignKey(d => d.HallId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConferenceHallBookingSessions_ConferenceHalls");

            entity.HasOne(d => d.Session).WithMany(p => p.ConferenceHallBookingSessions)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConferenceHallBookingSessions_ConferenceHallSessions");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.ConferenceHallBookingSessions)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConferenceHallBookingSessions_MasterBookingStatusCodes");
        });

        modelBuilder.Entity<ConferenceHallSession>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PK_ConferenceHall_Sessions");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedFrom).HasMaxLength(50);
            entity.Property(e => e.SessionEn).HasMaxLength(500);
            entity.Property(e => e.SessionHi).HasMaxLength(500);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);

            entity.HasOne(d => d.Hall).WithMany(p => p.ConferenceHallSessions)
                .HasForeignKey(d => d.HallId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConferenceHallSessions_ConferenceHalls");
        });

        modelBuilder.Entity<MasterBookingStatusCode>(entity =>
        {
            entity.HasKey(e => e.MasterBookingStatusId);

            entity.Property(e => e.MasterBookingStatusId).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedFrom).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.StatusTextEn).HasMaxLength(50);
            entity.Property(e => e.StatusTextHi).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<MasterRoomType>(entity =>
        {
            entity.HasKey(e => e.RoomTypeId);

            entity.Property(e => e.RoomTypeId).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedFrom).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.RoomTypeEn).HasMaxLength(500);
            entity.Property(e => e.RoomTypeHi).HasMaxLength(500);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        modelBuilder.Entity<TempEmployeeRole>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedFrom).HasMaxLength(50);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
