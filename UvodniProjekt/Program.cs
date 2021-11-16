using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodniProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //varijable
            int ocjena;
            double zbrojOcjena=0.00;
            double brojPredmeta = 0.00;
            double prosjek=0.00;

            //zaglavlje aplikacije
            Console.WriteLine("##############################");
            Console.WriteLine("#  Izraačunavanje prosjeka   #");
            Console.WriteLine("##############################");
            Console.WriteLine("Za kraj unesi nulu. ");
            do
            {
                //unos ocijene
                Console.WriteLine("Unesi ocjenu: ");
                ocjena = Convert.ToInt32(Console.ReadLine());
                if(ocjena<= 5 && ocjena > 1)
                {

                
                //dodavanje ocjene u zbrojOcjena
                zbrojOcjena += ocjena;

                //brojanje predmeta
                
                    brojPredmeta++;
          
                    prosjek = zbrojOcjena / brojPredmeta;
                }
                else if(ocjena== 1)
                {
                    prosjek = 1;
                    break;

                }
                else
                {
                    Console.WriteLine("Upišite ispravnu ocjenu");
                }

            }

            while (ocjena != 0);

          
            Console.WriteLine("prosjek ocjena je: " + prosjek);
            //kraj aplikacije
            Console.ReadKey();
        }
    }
}
