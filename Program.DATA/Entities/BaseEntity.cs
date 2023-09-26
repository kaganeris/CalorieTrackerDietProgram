using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            IsActive = true;
            CreatedDate = DateTime.Now;
        }
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
