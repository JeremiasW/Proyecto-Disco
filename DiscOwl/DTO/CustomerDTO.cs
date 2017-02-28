using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscOwl.DTO
{
    public class CustomerDTO
    {
        public CustomerDTO()
        {
            this.ScoreSet = new HashSet<ScoreDTO>();
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }

        public ICollection<ScoreDTO> ScoreSet { get; set; }
    }
}