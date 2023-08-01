using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstSite.Models
{
    public class Wzfrs
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Wzfrs(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
