using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FormsSQLite
{
    public class LocationItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int Spay { get; set; }
        public float Num { get; set; }
        public DateTime Day { get; set; }
    }
}
