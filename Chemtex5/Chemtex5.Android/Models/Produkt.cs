using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chemtex5.Models
{
    class Produkt
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Count { get; set; }

        public override string ToString()
        {
            return this.Name + "(" + this.Count +")";
        }
    }
}
