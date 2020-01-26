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
        public int ReleasedYear { get; set; }
        public int Sales { get; set; }

        public Album(string albumname,int release,int sales)
        {

            ReleasedYear = release;
            Sales = sales;
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
