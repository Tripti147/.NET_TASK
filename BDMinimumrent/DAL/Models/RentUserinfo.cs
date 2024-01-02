using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class RentUserinfo
    {
        public int id { get; set; }
        [Required]
        public string info { get; set; }

        [Required]
        public string userdescription { get; set; }

        [ForeignKey("RentUser")]
        public string userpostinfo { get; set; }
        public DateTime Datetime { get; set; }

        public virtual RentUser RentUser { get; set; }

        public virtual ICollection<RentUserreview> RentUserreviews { get; set; }
        public RentUserinfo()
        {
            RentUserreviews = new List<RentUserreview>();
        }

        public static explicit operator bool(RentUserinfo v)
        {
            throw new NotImplementedException();
        }
    }
}
