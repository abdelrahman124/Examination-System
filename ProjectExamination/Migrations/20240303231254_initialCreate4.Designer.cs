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
    [Migration("20240303231254_initialCreate4")]
    partial class initialCreate4
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

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("QuestionNum")
                        .HasColumnType("int");

                    b.Property<int>("Subid")
                        .HasColumnType("int");

                    b.Property<float>("Time")
                        .HasColumnType("real");

                    b.HasKey("Examsid");

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

                    b.Property<float>("Mark")
                        .HasColumnType("real");

                    b.Property<int>("Model_Answer")
                        .HasColumnType("int");

                    b.Property<string>("Qbody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QusetionNum")
                        .HasColumnType("int");

                    b.Property<int>("User_Answer")
                        .HasColumnType("int");

                    b.HasKey("QuestionsId");

                    b.HasIndex("Examsid");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ProjectExamination.Models.Students", b =>
                {
                    b.Property<int>("StudentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentsId"));

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<string>("SPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentsId");

                    b.HasIndex("LoginId")
                        .IsUnique();

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ProjectExamination.Models.Subjects", b =>
                {
                    b.Property<int>("SubjectsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectsId"));

                    b.Property<int>("Examsid")
                        .HasColumnType("int");

                    b.Property<string>("Subname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectsId");

                    b.HasIndex("Examsid")
                        .IsUnique();

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("ProjectExamination.Models.studentExam", b =>
                {
                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int>("examId")
                        .HasColumnType("int");

                    b.Property<int>("mark")
                        .HasColumnType("int");

                    b.HasKey("studentId", "examId");

                    b.HasIndex("examId");

                    b.ToTable("studentExam");
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

            modelBuilder.Entity("ProjectExamination.Models.Students", b =>
                {
                    b.HasOne("ProjectExamination.Models.Login", "Login")
                        .WithOne("Student")
                        .HasForeignKey("ProjectExamination.Models.Students", "LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Login");
                });

            modelBuilder.Entity("ProjectExamination.Models.Subjects", b =>
                {
                    b.HasOne("ProjectExamination.Models.Exams", "Exam")
                        .WithOne("Subject")
                        .HasForeignKey("ProjectExamination.Models.Subjects", "Examsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("ProjectExamination.Models.studentExam", b =>
                {
                    b.HasOne("ProjectExamination.Models.Exams", "Exam")
                        .WithMany("StudentExams")
                        .HasForeignKey("examId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectExamination.Models.Students", "Student")
                        .WithMany("StudentExams")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ProjectExamination.Models.Exams", b =>
                {
                    b.Navigation("GetQuestions");

                    b.Navigation("StudentExams");

                    b.Navigation("Subject")
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectExamination.Models.Login", b =>
                {
                    b.Navigation("Student")
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectExamination.Models.Students", b =>
                {
                    b.Navigation("StudentExams");
                });
#pragma warning restore 612, 618
        }
    }
}
