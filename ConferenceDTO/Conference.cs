using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDTO
{
    public class Conference
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Attendee> Attendees { get; set; }
    }
}
