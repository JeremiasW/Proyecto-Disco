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
        [Column("IdDisco")]
        public int DiscId { get; set; }
        [Column("IdTipo")]
        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public virtual Models.Type TypeElement { get; set; }
    }
}