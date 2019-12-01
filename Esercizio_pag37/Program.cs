using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esercizio_pag37
{
    class Program
    {
        static void Main(string[] args)
        {
            var risultato1 = Task.Factory.StartNew(Operazione1);

            var risultato2 = Task.Factory.StartNew(Operazione2);

            var risultato3 = Task.Factory.StartNew(Operazione3);

            Task.WaitAll(risultato2, risultato3);

            var risultato4 = risultato2.Result * risultato3.Result;

            var risultato5 = risultato4 + risultato1.Result;

            Console.WriteLine(risultato5);

            Console.ReadLine();

        }

        private static int Operazione3()
        {
            return 5 - 2;
        }

        private static int Operazione2()
        {
            return 1 + 4;
        }

        private static int Operazione1()
        {
            return 2 * 6;
        }
    }
}
