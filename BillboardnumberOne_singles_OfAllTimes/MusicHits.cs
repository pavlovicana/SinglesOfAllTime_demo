using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillboardnumberOne_singles_OfAllTime
{
    public class MusicHits
    {
        internal string artist;
        internal string single;
        internal int released;


        public MusicHits(string artist, string single, int released)
        {
            this.artist = artist;
            this.single = single;
            this.released = released;
        }
    }
}
