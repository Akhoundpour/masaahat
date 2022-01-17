using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace masahat_mohit
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Title ="Masahat & Mohit";
            Console.Write("SHoa Ra Vared Konid ---> ");
            double  Radius = double.Parse(Console.ReadLine());

            double masahat = (Radius * Radius) * 3.14;
            double mohit = 2 * Radius * 3.14;

            Console.WriteLine ("<-----------------------------------------------> ");
            Console.WriteLine(" Masahat : {0} , Mohit : {1}", masahat, mohit);
            Console.WriteLine ("<-----------------------------------------------> ");
            Console.ReadKey();

        }
    }
}
