using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using ProjectExamination.Models;

namespace lab_1_E_F.Models;

public partial class ExamnationSystemcontext : DbContext
{
    public ExamnationSystemcontext()
    {
    }

    public ExamnationSystemcontext(DbContextOptions<ExamnationSystemcontext> options)
        : base(options)
    {
    }

    public virtual DbSet<Login> logins { get; set; }

    public virtual DbSet<Exams> Exams { get; set; }

    public virtual DbSet<Questions> Questions { get; set; }

    public virtual DbSet<Students> Students { get; set; }
    public virtual DbSet<Subjects> Subjects { get; set; }

    public virtual DbSet<StudentSubject> StudentSubject { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
=> optionsBuilder.
        UseSqlServer("Server=.;Database=exam_Systm;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        modelBuilder.Entity<Exams>(entity =>
        {
            entity.HasKey(e => e.Examsid);
        });



        modelBuilder.Entity<StudentSubject>()
            .HasKey(e => new { e.studentId, e.subjectId });


        modelBuilder.Entity<Login>()
            .HasIndex(l => l.StudentsId) // Create an index on CustomerId
            .IsUnique();
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
