using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Data
{
    public class BackEndContext : DbContext
    {
        public BackEndContext (DbContextOptions<BackEndContext> options)
            : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<Session> Sessions { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Attendee> Attendee { get; set; }
        public DbSet<Tag> Tag { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<SessionSpeaker>().HasKey(sp => new { sp.SessionID, sp.SpeakerID });
            modelBuilder.Entity<SessionAttendee>().HasKey(sp => new { sp.SessionID, sp.AttendeeID });
            modelBuilder.Entity<SessionTag>().HasKey(sp => new { sp.SessionID, sp.TagID });
        }
    }
}
