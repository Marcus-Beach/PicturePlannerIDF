using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlannerIDF.Models
{
    public class Plan
    {
        public int PlanId { get; set; }

        public int? SharedPlanId { get; set; }
        [ForeignKey("Thing")]
        public int? FloorId { get; set; }

        public int? SharedFloorId { get; set; }

        public string OwnerId { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }

        public Thing Thing { get; set; }
    }
}
