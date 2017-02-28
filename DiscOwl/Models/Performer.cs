using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiscOwl.Models
{
    public class Performer
    {
        [Key]
        [Column("IdInterprete")]
        public int Id { get; set; }
        [Column("Interprete")]
        public String PerformerName { get; set; }
    }
}