using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscOwl.DTO
{
    public class DiscDTO
    {
        public DiscDTO()
        {
            this.DiscTypeSet = new HashSet<DiscTypeDTO>();
            this.ScoreSet = new HashSet<ScoreDTO>();
        }

        public int DiscId { get; set; }
        public String Title { get; set; }
        public Nullable<System.Double> Year { get; set; }
        public int PerformerId { get; set; }

        public PerformerDTO Performer { get; set; }
        public ICollection<DiscTypeDTO> DiscTypeSet { get; set; }
        public ICollection<ScoreDTO> ScoreSet { get; set; }
    }
}