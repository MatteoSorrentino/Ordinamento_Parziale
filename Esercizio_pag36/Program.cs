using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_pag36
{
    class Program
    {
        public static int x;

        static void Main(string[] args)
        {

            var risultato1 = Task.Factory.StartNew(LetturaX);

            Console.WriteLine(risultato1);

            Console.ReadLine();

        }

        private static int LetturaX()
        {
            return x = Convert.ToInt32(Console.ReadLine());
        }
    }
}
