using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillboardnumberOne_singles_OfAllTime
{
    class HitsofAllTime
    {
        private static List<MusicHits> listOfhits = new List<MusicHits>();
      

        public HitsofAllTime() { }

        public void ListOfHits(MusicHits hit)
        {
            listOfhits.Add(hit);
           // listOfhits.OrderBy(x => x.released);
        }
        public void GuessTheYear(int option, int year)
        {
            int counter = 0;
            switch (option)
            {
                
                case 1:
                    
                    foreach (var k in listOfhits)
                    {                       
                        if (k.released == year)
                        {
                            counter++;
                        }
                    }
                    MusicHits[] oftheYear = new MusicHits[counter];
                    Console.WriteLine(counter);
                    int n = counter - 1;
                    foreach (var item in listOfhits)
                    {
                       
                        if (item.released == year)
                        {
                            oftheYear[n] =item;
                            n--;
                        }
                    }
                                           
                    Console.WriteLine("Of the year");
                    Console.WriteLine("-----------");
                    foreach(var item in oftheYear)
                    {
                        Console.WriteLine("{0} {1} {2}", item.artist, item.single, item.released);
                        Console.WriteLine("------------------------------");
                    }
                    break;
                case 2:

                    foreach (var k in listOfhits)
                    {
                        if (k.released > year)
                        {
                            counter++;
                        }
                    }
                    MusicHits[] aftertheYear = new MusicHits[counter];
                    for (int i = 0; i < listOfhits.Count; i++)
                    {
                        if (listOfhits[i].released > year)
                        {
                            aftertheYear[i] = listOfhits[i];
                        }
                    }
                    Console.WriteLine("After the year");
                    Console.WriteLine("--------------");
                    foreach (var item in aftertheYear)
                    {
                        Console.WriteLine("{0} {1} {2}", item.artist, item.single, item.released);
                        Console.WriteLine("------------------------------");
                    }
                    break;
                case 3:
                    foreach (var k in listOfhits)
                    {
                        if (k.released < year)
                        {
                            counter++;
                        }
                    }
                    MusicHits[] beforetheYear = new MusicHits[counter];
                    for (int i = 0; i < listOfhits.Count; i++)
                    {
                        if (listOfhits[i].released < year)
                        {
                            listOfhits[i] = beforetheYear[i];
                        }
                    }
                    Console.WriteLine("Before that year");
                    Console.WriteLine("----------------");
                    foreach (var item in beforetheYear)
                    {
                        Console.WriteLine("{0} {1} {2}", item.artist, item.single, item.released);
                        Console.WriteLine("------------------------------");
                    }
                    break;

                default:
                    Console.WriteLine("Wrong option.");
                    break;
            }
        }
    }
}
 


    

            
            


