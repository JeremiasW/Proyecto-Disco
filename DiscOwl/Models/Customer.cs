using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiscOwl.Models
{
    public class Customer
    {
        public Customer()
        {
            this.ScoreSet = new HashSet<Score>();
        }

        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }

        public virtual ICollection<Score> ScoreSet { get; set; }
    }
}