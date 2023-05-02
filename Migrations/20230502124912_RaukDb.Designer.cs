﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication5.Models;

#nullable disable

namespace WebApplication5.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230502124912_RaukDb")]
    partial class RaukDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication5.Models.ApplicationAndEvaluation", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationId"));

                    b.Property<string>("Accompanying_SupportStaff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationStatus")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Archived_Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("AverageRating")
                        .HasColumnType("real");

                    b.Property<float>("Average_TotalPoints_Application")
                        .HasColumnType("real");

                    b.Property<string>("Dnr")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Exchange_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrameCaseNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("Period")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("PeriodDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("PointDifference")
                        .HasColumnType("real");

                    b.Property<float>("PointDifference_ApplicationView")
                        .HasColumnType("real");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.Property<float>("QualityPoints_Report")
                        .HasColumnType("real");

                    b.Property<string>("Theme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Weighted_AveragePoints")
                        .HasColumnType("real");

                    b.Property<float>("Weighted_QualityPoints_BudgetView")
                        .HasColumnType("real");

                    b.HasKey("ApplicationId");

                    b.ToTable("ApplicationAndEvaluations");
                });

            modelBuilder.Entity("WebApplication5.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizationId"));

                    b.Property<string>("AccountHolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationEmail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("OrganizationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plus_Bankgiro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("WebApplication5.Models.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParticipantId"));

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("Applied_Participant_Number")
                        .HasColumnType("int");

                    b.Property<int>("Applied_Staff_Teacher_Number")
                        .HasColumnType("int");

                    b.Property<int>("Applied_Student_Number")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Granted_Participant_Number")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reported_Men_AssociatedStaff_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Men_SchoolLeader_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Men_Student_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Men_Teacher_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Participant_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Staff_Teacher_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Student_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Women_AssociatedStaff_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Women_SchoolLeader_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Women_Student_Number")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Women_Teacher_Number")
                        .HasColumnType("int");

                    b.HasKey("ParticipantId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("WebApplication5.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<float>("Applied_AdminGrant")
                        .HasColumnType("real");

                    b.Property<float>("Applied_Amount_ExtraFunds")
                        .HasColumnType("real");

                    b.Property<float>("Applied_Amount_Scholarships")
                        .HasColumnType("real");

                    b.Property<float>("Applied_AuditGrant")
                        .HasColumnType("real");

                    b.Property<float>("Approved_Adjusted_Amount_ExtraFunds")
                        .HasColumnType("real");

                    b.Property<float>("Approved_Amount_Scholarships")
                        .HasColumnType("real");

                    b.Property<float>("Granted_AdminGrant")
                        .HasColumnType("real");

                    b.Property<float>("Granted_Amount_ExtraFunds")
                        .HasColumnType("real");

                    b.Property<float>("Granted_Amount_Scholarships")
                        .HasColumnType("real");

                    b.Property<float>("Granted_AuditGrant")
                        .HasColumnType("real");

                    b.Property<float>("PaymentAmount")
                        .HasColumnType("real");

                    b.Property<float>("Reported_Amount_ExtraFunds")
                        .HasColumnType("real");

                    b.Property<float>("Total_Applied_Amount")
                        .HasColumnType("real");

                    b.Property<float>("Total_Approved_Amount")
                        .HasColumnType("real");

                    b.Property<float>("Total_Granted_Amount")
                        .HasColumnType("real");

                    b.Property<float>("Total_Reported_Amount")
                        .HasColumnType("real");

                    b.HasKey("PaymentId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("WebApplication5.Models.PreviousApplication", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationId"));

                    b.Property<int>("PreviousDnr")
                        .HasColumnType("int");

                    b.HasKey("ApplicationId");

                    b.ToTable("PreviousApplications");
                });

            modelBuilder.Entity("WebApplication5.Models.Program", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramId"));

                    b.Property<string>("EducationLevel")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("EducationalProgram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrantArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerSchool_EducationLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Semester")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To_Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weeks")
                        .HasColumnType("int");

                    b.HasKey("ProgramId");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("WebApplication5.Models.ReportAndReclaim", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportId"));

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_when_ReportStatus_Set")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfReportedAbortedScholarships")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfReportedCompletedScholarships")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfReportedNotAwardedScholarships")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfReportedScholarships")
                        .HasColumnType("int");

                    b.Property<float>("Reclaim_Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("Reclaim_Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Reclaim_Paid_Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("Reclaim_Paid_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReportStatus")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("ReportStatusDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status_Report")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReportId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("ReportAndReclaims");
                });

            modelBuilder.Entity("WebApplication5.Models.ScholarshipAndGrant", b =>
                {
                    b.Property<int>("ScholarshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScholarshipId"));

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("Applied_Number_Of_Days")
                        .HasColumnType("int");

                    b.Property<DateTime>("Applied_Year_Month")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfAppliedScholarships")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGrantedScholarships")
                        .HasColumnType("int");

                    b.Property<string>("PreviousApplication_Dnr")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Project")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProjectYear")
                        .HasColumnType("int");

                    b.Property<int>("Reported_Number_Of_Days")
                        .HasColumnType("int");

                    b.Property<DateTime>("Reported_Year_Month")
                        .HasColumnType("datetime2");

                    b.HasKey("ScholarshipId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("ScholarshipAndGrants");
                });

            modelBuilder.Entity("WebApplication5.Models.Participant", b =>
                {
                    b.HasOne("WebApplication5.Models.ApplicationAndEvaluation", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("WebApplication5.Models.Payment", b =>
                {
                    b.HasOne("WebApplication5.Models.ApplicationAndEvaluation", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("WebApplication5.Models.ReportAndReclaim", b =>
                {
                    b.HasOne("WebApplication5.Models.ApplicationAndEvaluation", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("WebApplication5.Models.ScholarshipAndGrant", b =>
                {
                    b.HasOne("WebApplication5.Models.ApplicationAndEvaluation", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });
#pragma warning restore 612, 618
        }
    }
}
