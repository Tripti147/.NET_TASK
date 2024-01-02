using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class RentUserreview
    {
        public int id { get; set; }
        [Required]
        public string userreview { get; set; }


        public DateTime time { get; set; }

        [ForeignKey("RentUser")]
        public string userreviewinfo { get; set; }

        [ForeignKey("RentUserinfo")]
        public int userpostinfoid { get; set; }

        public string userreviewdto { get; set; }

        public virtual RentUserinfo RentUserinfo { get; set; }
        public virtual RentUser RentUser { get; set; }

        public static explicit operator bool(RentUserreview v)
        {
            throw new NotImplementedException();
        }
    }
}
