using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startlista
{
    public class Versenyszam : IComparable<Versenyszam>
    {
        public FileInfo Pdf { get; set; }
        public DateTime DateTime { get; set; }
        public Versenyszam(FileInfo pdf, DateTime dateTime)
        {
            Pdf = pdf;
            DateTime = dateTime;
        }

        public int CompareTo(Versenyszam other)
        {
            return DateTime.CompareTo(other.DateTime);
        }
    }
}
