using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODWeek1Lab1
{

    public enum BandType
    {
        Pop,
        Rock,
        Indie,
        All
    }


    public abstract class Band : IComparable
    {
        public string BandName { get; set; }
        public DateTime YearFormed { get; set; }
        public List<Album> albums { get; set; }
        public List<string> Members { get; set; }

        public Band(string bandname,DateTime year,List<string> members,BandType band)
        {
            BandName = bandname;
            YearFormed = year;
            Members = members;
            
        }

        public Band()
        {

        }

        public override string ToString()
        {
            return BandName;
        }

        public int CompareTo(object obj)
        {
            Band that = (Band)obj;
            return BandName.CompareTo(that.BandName);
        }
    }

    public class Indie : Band
    {
        public Indie(string bandname, DateTime year, List<string> members,BandType  band) : base(bandname, year, members, band)
        {
            
        }

        public override string ToString()
        {
            return BandType.Indie + " - " + BandName;
        }
    }

    public class Rock : Band
    {
        

        public Rock(string bandname, DateTime year, List<string> members, BandType band) : base(bandname, year, members, band)
        {
        }

        public override string ToString()
        {
            return BandType.Rock + " - " + BandName;
        }
    }

    public class PoP : Band
    {
        public PoP(string bandname, DateTime year, List<string> members, BandType band) : base(bandname, year, members, band)
        {

        }
        public override string ToString()
        {
            return BandType.Pop + " - " + BandName;
        }
    }
}
