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
        [Column("IdCliente")]
        public int CustomerId { get; set; }
        [Column("IdDisco")]
        public int DiscId { get; set; }
        [Column("Puntuacion")]
        public int ScoreValue { get; set; }

        [ForeignKey("DiscId")]
        public virtual Disc Disc { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}