using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sVelika, sMala, sPrvaTri, sZadnjihPet, s8_11;
            Console.WriteLine("Unesite recenicu:");
            sVelika = Console.ReadLine();
            Console.WriteLine("Ispis velikim slovima: {0}, " +
            "\nIspis malim slovima: {1}",
            sVelika.ToUpper(), sVelika.ToLower());
            
            Console.WriteLine("Unesite prva tri znaka");
            sPrvaTri = Console.ReadLine();
            Console.WriteLine(sPrvaTri.Substring(0, 3));
            Console.WriteLine(sPrvaTri);
            Console.WriteLine("Unesite zadnjih pet znakova:");
            sZadnjihPet = Console.ReadLine();
            Console.WriteLine(sZadnjihPet.Substring(0, 5));
            Console.WriteLine("Unesite znakove od 8 do 11:");
            s8_11 = Console.ReadLine();
            Console.WriteLine(s8_11.Substring(s8_11.Length - 1, 3));
            Console.ReadLine();


        }
    }
}
