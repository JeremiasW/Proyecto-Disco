using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiscOwl.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DiscId { get; set; }

        [Column("Puntuacion")]
        public int ScoreValue { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Disc Disc { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Customer Customer { get; set; }
    }
}