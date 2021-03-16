using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumento_params
{
    class Arg_params
    {
        static void Main(string[] args)
        {
            Soma(10, 3, 5, 44, 58, 59);
            Soma(2);
            Soma();

            Console.ReadLine();
        }

        static void Soma(params int[]n)
        {
            int res = 0;

            if (n.Length < 1)
            {
                Console.WriteLine("Não existem valores a serem somados");
            }
            else if (n.Length < 2)
            {
                Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
            }
            else 
            {
                foreach (int numero in n)
                {
                    res += numero;
                }
                Console.WriteLine("A soma dos valores é {0}", res);
            }
        }
    }
}
