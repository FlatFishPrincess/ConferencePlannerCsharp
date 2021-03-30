using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Session
    {
        public int ID { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }
        public string Title { get; set; }
        
        public virtual ICollection<Speaker> Speakers { get; set;  }
    }
}
