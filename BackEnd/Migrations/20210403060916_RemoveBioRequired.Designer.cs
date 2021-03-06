// <auto-generated />
using System;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
    [DbContext(typeof(BackEndContext))]
    [Migration("20210403060916_RemoveBioRequired")]
    partial class RemoveBioRequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.Models.Attendee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("ID");

                    b.ToTable("Attendee");
                });

            modelBuilder.Entity("BackEnd.Models.Session", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abstract")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int?>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("EndTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("StartTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrackID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TrackID");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("BackEnd.Models.SessionAttendee", b =>
                {
                    b.Property<int>("SessionID")
                        .HasColumnType("int");

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.HasKey("SessionID", "AttendeeID");

                    b.HasIndex("AttendeeID");

                    b.ToTable("SessionAttendee");
                });

            modelBuilder.Entity("BackEnd.Models.SessionSpeaker", b =>
                {
                    b.Property<int>("SessionID")
                        .HasColumnType("int");

                    b.Property<int>("SpeakerID")
                        .HasColumnType("int");

                    b.HasKey("SessionID", "SpeakerID");

                    b.HasIndex("SpeakerID");

                    b.ToTable("SessionSpeaker");
                });

            modelBuilder.Entity("BackEnd.Models.SessionTag", b =>
                {
                    b.Property<int>("SessionID")
                        .HasColumnType("int");

                    b.Property<int>("TagID")
                        .HasColumnType("int");

                    b.HasKey("SessionID", "TagID");

                    b.HasIndex("TagID");

                    b.ToTable("SessionTag");
                });

            modelBuilder.Entity("BackEnd.Models.Speaker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("WebSite")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("ID");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("BackEnd.Models.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("BackEnd.Models.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("BackEnd.Models.Session", b =>
                {
                    b.HasOne("BackEnd.Models.Track", "Track")
                        .WithMany("Sessions")
                        .HasForeignKey("TrackID");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("BackEnd.Models.SessionAttendee", b =>
                {
                    b.HasOne("BackEnd.Models.Attendee", "Attendee")
                        .WithMany("SessionAttendees")
                        .HasForeignKey("AttendeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.Session", "Session")
                        .WithMany()
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attendee");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("BackEnd.Models.SessionSpeaker", b =>
                {
                    b.HasOne("BackEnd.Models.Session", "Session")
                        .WithMany("SessionSpeakers")
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.Speaker", "Speaker")
                        .WithMany("SessionSpeakers")
                        .HasForeignKey("SpeakerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("BackEnd.Models.SessionTag", b =>
                {
                    b.HasOne("BackEnd.Models.Session", "Session")
                        .WithMany("SessionTags")
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.Tag", "Tag")
                        .WithMany("SessionTags")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("BackEnd.Models.Attendee", b =>
                {
                    b.Navigation("SessionAttendees");
                });

            modelBuilder.Entity("BackEnd.Models.Session", b =>
                {
                    b.Navigation("SessionSpeakers");

                    b.Navigation("SessionTags");
                });

            modelBuilder.Entity("BackEnd.Models.Speaker", b =>
                {
                    b.Navigation("SessionSpeakers");
                });

            modelBuilder.Entity("BackEnd.Models.Tag", b =>
                {
                    b.Navigation("SessionTags");
                });

            modelBuilder.Entity("BackEnd.Models.Track", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
