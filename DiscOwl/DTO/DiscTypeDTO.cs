using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscOwl.DTO
{
    public class DiscTypeDTO
    {
        public int Id { get; set; }
        public int DiscId { get; set; }
        public int TypeId { get; set; }

        public TypeDTO TypeElement { get; set; }
    }
}