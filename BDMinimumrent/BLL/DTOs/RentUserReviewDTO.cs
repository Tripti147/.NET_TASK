using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RentUserReviewDTO
    {
        public int id { get; set; }
        [Required]
        public string userreview { get; set; }
        public DateTime time { get; set; }
        public string userreviewinfo { get; set; }

        public int userpostinfoid { get; set; }

        public string userreviewdto { get; set; }

    }
}