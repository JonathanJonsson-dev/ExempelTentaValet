using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    public class Election
    {
        public List<Party> Parties { get; set; }

        public Election()
        {
            Parties = new List<Party>();
        }

        public void AddParty(string name, string abbreviation, int numberOfVotes)
        {
            Party party = new Party(name, abbreviation, numberOfVotes);
            Parties.Add(party);
        }

        public Party Search(string abbreviation)
        {

            foreach (Party party in Parties)
            {
                if (party.Abbreviation == abbreviation.ToUpper())
                {
                    return party;
                }
            }
            return null;
        }
    }
}
