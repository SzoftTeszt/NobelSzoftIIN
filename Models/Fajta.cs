using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelDij.Models
{
    internal class Fajta
    {
        [Key]
        public int Id { get; set; } 
        public string Tipus { get; set; }

        public Fajta() { }

        public Fajta(string tipus)
        {
            Tipus = tipus;
        }

        public override string ToString()
        {
            return Id + ":" + Tipus;
        }
    }
}
