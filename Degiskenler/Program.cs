using System;
namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {


                       
            int uzunkenar, kisakenar, alan, cevre;
            uzunkenar = 15;
            kisakenar = 20;
            alan = uzunkenar * kisakenar;
            cevre = 2 * (uzunkenar + kisakenar);
            Console.WriteLine("Alan : "  +alan + " " + "Cevre : " +cevre);
            Console.ReadLine();


        }

        
    }

}