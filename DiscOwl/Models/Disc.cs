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
        }

        [Key]
        public int DiscId { get; set; }
        public String Title { get; set; }
        public Nullable<System.Int32> Year { get; set; }
        public int PerformerId { get; set; }

        [ForeignKey("IdInterprete")]
        public virtual Performer Performer { get; set; }
        public virtual ICollection<DiscType> DiscTypeSet { get; set; }
    }
}