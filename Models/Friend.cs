
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlannerIDF.Models
{
    public class Friend
    {
        [Key]
        public int UserFriendId { get; set; }

        public string FriendID { get; set; }

        public string UserID { get; set; }

        public bool Confirmed { get; set; }
    }
}