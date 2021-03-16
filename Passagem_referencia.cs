using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagem_por_Referência
{
    class Passagem_referencia
    {
        static void Main(string[] args)
        {
            int num = 10;
            dobrar(num);
            Console.WriteLine(num);

            dobrarRef(ref num);
            Console.WriteLine(num);

            Console.ReadLine();
        }

        static void dobrar(int valor)
        {
            valor *= 2;
        }

        static void dobrarRef(ref int valor)
        {
            valor *= 2;
        }

    }
}
