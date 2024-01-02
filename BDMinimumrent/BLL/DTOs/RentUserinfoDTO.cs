using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RentUserinfoDTO
    {
        public int id { get; set; }
        [Required]
        public string info { get; set; }
        [Required]
        public string userdescription { get; set; }
        [Required]
        public string userpostinfo { get; set; }
        [Required]
        public DateTime Datetime { get; set; }
    }
}