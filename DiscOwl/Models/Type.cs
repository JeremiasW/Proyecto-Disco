using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiscOwl.Models
{
    public class Type
    {
        [Key]
        [Column("IdTipo")]
        public int Id { get; set; }
        [Column("Tipo")]
        public String TypeName { get; set; }
    }
}