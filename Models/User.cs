using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlannerIDF.Models
{
    public class User
    {
        public int UserId { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }

        public int Status { get; set; }

        public DateTime? ExpiryDate { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        [MaxLength(255)]
        public string Password { get; set; }

    }
}