using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Speaker
    {
        public int ID { get; set; }
        public string Bio { get; set; }
        public string Name { get; set; }
        public string WebSite { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }

    }
}
