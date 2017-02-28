using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscOwl.ViewModel
{
    public class DiscViewModel
    {
        public String DiscName { get; set; }
        public String Author { get; set; }
        public ICollection<String> TypeSet { get; set; }
        public int Score { get; set; }
    }
}