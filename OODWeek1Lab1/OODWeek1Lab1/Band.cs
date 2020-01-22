using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODWeek1Lab1
{
    public class Band : IComparable
    {
        public string BandName { get; set; }
        public DateTime YearFormed { get; set; }

        public List<string> Members { get; set; }

        public Band(string bandname,DateTime year,List<string> members)
        {
            BandName = bandname;
            YearFormed = year;
            Members = members;
        }

        public override string ToString()
        {
            return BandName;
        }

        public int CompareTo(object obj)
        {
            Band that = (Band)obj;
            return this.BandName.CompareTo(that.BandName);
        }
    }
}
