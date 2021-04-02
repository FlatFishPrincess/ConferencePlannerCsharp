﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDTO
{
    public class Session
    {
        public int ID { get; set; }
        [StringLength(4000)]
        public virtual string Abstract { get; set; }

        public virtual DateTimeOffset? StartTime { get; set; }

        public virtual DateTimeOffset? EndTime { get; set; }

        public TimeSpan Duration => EndTime?.Subtract(StartTime ?? EndTime ?? DateTimeOffset.MinValue) ?? TimeSpan.Zero;

        public string Title { get; set; }

        public int? TrackId { get; set; }
        public int? ConferenceId { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

    }
}