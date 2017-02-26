using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiscOwl.Models
{
    public class DiscType
    {
        [Key]
        public int Id { get; set; }
        public int DiscId { get; set; }
        public int TypeId { get; set; }

        [ForeignKey("IdTipo")]
        public virtual Type TypeElement { get; set; }
    }
}