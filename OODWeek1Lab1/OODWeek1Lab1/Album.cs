using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODWeek1Lab1
{
    public class Album
    {
        public string AlbumName { get; set; }
        int ReleasedYear;
        public int Sales { get; set; }

        public Album(string albumname)
        {

            Random rng = new Random();

            ReleasedYear = rng.Next(2000, 2020);
            Sales = rng.Next(50, 200);
            
            AlbumName = albumname;
            
        }

        public Album()
        {
        }

        public override string ToString()
        {
            return AlbumName + ReleasedYear + Sales;
        }
    }
}
