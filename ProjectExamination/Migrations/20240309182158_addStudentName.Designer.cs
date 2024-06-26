﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab_1_E_F.Models;

#nullable disable

namespace ProjectExamination.Migrations
{
    [DbContext(typeof(ExamnationSystemcontext))]
    [Migration("20240309182158_addStudentName")]
    partial class addStudentName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectExamination.Models.Exams", b =>
                {
                    b.Property<int>("Examsid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Examsid"));

                    b.Property<int>("QuestionNum")
                        .HasColumnType("int");

                    b.Property<int>("Subjectid")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Examsid");

                    b.HasIndex("Subjectid")
                        .IsUnique();

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ProjectExamination.Models.Login", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginId"));

                    b.Property<string>("LPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("LoginId");

                    b.HasIndex("StudentsId")
                        .IsUnique();

                    b.ToTable("logins");
                });

            modelBuilder.Entity("ProjectExamination.Models.Questions", b =>
                {
                    b.Property<int>("QuestionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionsId"));

                    b.Property<int>("Examsid")
                        .HasColumnType("int");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<int>("Model_Answer")
                        .HasColumnType("int");

                    b.Property<string>("Qbody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionsId");

                    b.HasIndex("Examsid");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ProjectExamination.Models.StudentSubject", b =>
                {
                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int>("subjectId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("studentId", "subjectId");

                    b.HasIndex("subjectId");

                    b.ToTable("StudentSubject");
                });

            modelBuilder.Entity("ProjectExamination.Models.Students", b =>
                {
                    b.Property<int>("StudentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentsId"));

                    b.Property<string>("StudenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentsId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ProjectExamination.Models.Subjects", b =>
                {
                    b.Property<int>("SubjectsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectsId"));

                    b.Property<string>("Subname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectsId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("ProjectExamination.Models.Exams", b =>
                {
                    b.HasOne("ProjectExamination.Models.Subjects", "Subject")
                        .WithOne("Exam")
                        .HasForeignKey("ProjectExamination.Models.Exams", "Subjectid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ProjectExamination.Models.Login", b =>
                {
                    b.HasOne("ProjectExamination.Models.Students", "Student")
                        .WithOne("Login")
                        .HasForeignKey("ProjectExamination.Models.Login", "StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ProjectExamination.Models.Questions", b =>
                {
                    b.HasOne("ProjectExamination.Models.Exams", "Exam")
                        .WithMany("GetQuestions")
                        .HasForeignKey("Examsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("ProjectExamination.Models.StudentSubject", b =>
                {
                    b.HasOne("ProjectExamination.Models.Students", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectExamination.Models.Subjects", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("subjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ProjectExamination.Models.Exams", b =>
                {
                    b.Navigation("GetQuestions");
                });

            modelBuilder.Entity("ProjectExamination.Models.Students", b =>
                {
                    b.Navigation("Login")
                        .IsRequired();

                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("ProjectExamination.Models.Subjects", b =>
                {
                    b.Navigation("Exam")
                        .IsRequired();

                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
