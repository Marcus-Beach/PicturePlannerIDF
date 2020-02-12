using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlannerIDF.Models
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }

        public int? SharedSettingId { get; set; }

        public bool CanMove { get; set; }

        public bool CanPlace { get; set; }

        public bool CanRemove { get; set; }
    }
}