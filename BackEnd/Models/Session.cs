using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Session : ConferenceDTO.Session
    {
        public virtual ICollection<SessionSpeaker> SessionSpeakers { get; set; }
        public virtual ICollection<SessionTag> SessionTags { get; set; }

        public Track Track { get; set; }
    }
}
