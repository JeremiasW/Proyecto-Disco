using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiscOwl.Models
{
    public class Disc
    {
        public Disc()
        {
            this.DiscTypeSet = new HashSet<DiscType>();
            this.ScoreSet = new HashSet<Score>();
        }

        [Key]
        [Column("IdDisco")]
        public int DiscId { get; set; }
        [Column("Titulo")]
        public String Title { get; set; }
        [Column("Agno")]
        public Nullable<System.Double> Year { get; set; }
        [Column("IdInterprete")]
        public int PerformerId { get; set; }

        [ForeignKey("PerformerId")]
        public virtual Performer Performer { get; set; }
        public virtual ICollection<DiscType> DiscTypeSet { get; set; }
        public virtual ICollection<Score> ScoreSet { get; set; }
    }
}