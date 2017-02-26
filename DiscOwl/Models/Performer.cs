using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiscOwl.Models
{
    public class Performer
    {
        [Key]
        public int Id { get; set; }
        public String PerformerName { get; set; }
    }
}