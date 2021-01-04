using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    public class Party
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public double Percentage { get; set; }
        public int NumberOfVotes { get; set; }

        public Party(string name, string abbreviation, int numberOfVotes)
        {
            Name = name;
            Abbreviation = abbreviation.ToUpper();
            NumberOfVotes = numberOfVotes;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
