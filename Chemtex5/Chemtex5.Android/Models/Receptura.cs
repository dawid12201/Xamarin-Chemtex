using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using Newtonsoft.Json;

namespace Chemtex5.Models
{
    public class Receptura
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surowce { get; set; }

        public override string ToString()
        {
            return this.Name +" (" + this.Surowce + ") " ;
        }

    }
}
