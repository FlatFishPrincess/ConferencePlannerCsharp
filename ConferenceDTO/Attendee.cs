using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDTO
{
    public class Attendee
    {
        public int ID { get; set; }
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(200)]
        public string LastName { get; set; }

        [StringLength(256)]
        public string UserName { get; set; }
        public virtual ICollection<Conference> Conferences { get; set; }
    }
}
