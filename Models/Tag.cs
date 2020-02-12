using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlannerIDF.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        public int? SharedTagId { get; set; }

        public string Name { get; set; }
    }
}