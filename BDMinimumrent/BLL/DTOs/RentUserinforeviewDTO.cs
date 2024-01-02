using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RentUserinforeviewDTO : RentUserinfoDTO
    {

        public List<RentUserReviewDTO> RentUserreviews { get; set; }
        public RentUserDTO RentUser { get; set; }
        public RentUserinforeviewDTO()
        {
            RentUserreviews = new List<RentUserReviewDTO>();

        }

    }

    public class RentUserReviewDTO
    {
    }
}