using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlannerIDF.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
#nullable enable
        public string? UserId { get; set; }
        public string? FriendId { get; set; }
        public int? PlanId { get; set; }
        public int? SharedPlanId { get; set; }
        public int? ThingId { get; set; }
        public int? SharedThingId { get; set; }
        public int? TagId { get; set; }
        public int? SharedTagId { get; set; }
        public int? SettingId { get; set; }
        public int? SharedSettingId { get; set; }
        public DateTime Date { get; set; }

    }
}