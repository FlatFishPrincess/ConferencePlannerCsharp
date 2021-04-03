using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDTO
{
    public class SessionResponse : Session
    {
        public virtual ICollection<Speaker> Speakers { get; set; }
        public Track Track { get; set; }

    }
}
