using Program.DATA.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class UserDetails : BaseEntity
    {
        public UserDetails()
        {
            Age = (DateTime.Now.Year - BirthDate.Year);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        [NotMapped]
        public int Age { get;}
        public float Height { get; set; }
        public float Weight { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
