﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column("Nombre")]
        public String Name { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        [Column("FechaNacimiento")]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [Column("FechaRegistro")]
        public Nullable<System.DateTime> RegisterDate { get; set; }

        public virtual ICollection<Score> ScoreSet { get; set; }
    }
}