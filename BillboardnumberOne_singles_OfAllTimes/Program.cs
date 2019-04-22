using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillboardnumberOne_singles_OfAllTime
{
    class Program
    {
        static void Main(string[] args)
        {

            MusicHits hit1 = new MusicHits("Michael Jackson", "Billie Jean", 1983);
            MusicHits hit2 = new MusicHits("Gloria Gaynor", "I will survive", 1978);
            MusicHits hit3 = new MusicHits("Ricky Martin", "Livin La Vida Loca", 1999);
            MusicHits hit4 = new MusicHits("Roy Orbinson", "Pretty Woman", 1964);
            MusicHits hit5 = new MusicHits("Christina Aguillera", "Genie in a Bottle", 1999);
            MusicHits hit6 = new MusicHits("Jackson 5", "I want you back", 1969);
            MusicHits hit7 = new MusicHits("Kyllie Minogue", "Can't get you of my mind", 2001);
            MusicHits hit8 = new MusicHits("Elvis Presley", "Surrender", 1961);
            MusicHits hit9 = new MusicHits("Ricky Martin", "Maria", 1995);
            MusicHits hit10 = new MusicHits("The Black Eyed Peas", "I gotta feeling", 2005);
            MusicHits hit11 = new MusicHits("Maroon 5 featuring Christina Aguilera", "Moves like Jagger", 2011);
            MusicHits hit12 = new MusicHits("Lady Gaga", "Poker face", 2008);
            MusicHits hit13 = new MusicHits("Survivor", "Eye Of The Tiger", 1982);
            MusicHits hit14 = new MusicHits("Aqua", "Barbie Girl", 1997);
            MusicHits hit15 = new MusicHits("Shakira", "Whenever, Wherever", 2001);
            MusicHits hit16 = new MusicHits("The Beatles", "Hey Jude", 1978);
            MusicHits hit17 = new MusicHits("Modern Talking", "You're My Heart, You're My Soul", 1984);
            MusicHits hit18 = new MusicHits("Nirvana", "Smells Like Teen Spirit", 1991);
            MusicHits hit19 = new MusicHits("Justin Bieber", "Love Yourself", 2015);
            MusicHits hit20 = new MusicHits("Bruno Mars", "Grenade", 2010);

            HitsofAllTime hits = new HitsofAllTime();
            hits.ListOfHits(hit1);
            hits.ListOfHits(hit2);
            hits.ListOfHits(hit3);
            hits.ListOfHits(hit4);
            hits.ListOfHits(hit5);
            hits.ListOfHits(hit6);
            hits.ListOfHits(hit7);
            hits.ListOfHits(hit8);
            hits.ListOfHits(hit9);
            hits.ListOfHits(hit10);
            hits.ListOfHits(hit11);
            hits.ListOfHits(hit12);
            hits.ListOfHits(hit13);
            hits.ListOfHits(hit14);
            hits.ListOfHits(hit15);
            hits.ListOfHits(hit16);
            hits.ListOfHits(hit17);
            hits.ListOfHits(hit18);
            hits.ListOfHits(hit19);
            hits.ListOfHits(hit20);

            hits.GuessTheYear(2, 1960);
            hits.GuessTheYear(1, 1999);
          //  hits.GuessTheYear(3, 1980);
            Console.ReadLine();

        }
    }
}
