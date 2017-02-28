using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscOwl.DTO
{
    public class ScoreDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DiscId { get; set; }
        public int ScoreValue { get; set; }

        public DiscDTO Disc { get; set; }
        public CustomerDTO Customer { get; set; }
    }
}