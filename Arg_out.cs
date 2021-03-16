using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumento_out
{
    class Arg_out
    {
        static void Main(string[] args)
        {
            int dividendo = 10, divisor = 4, resto, quociente;
            quociente = divide(dividendo, divisor, out resto);
            Console.WriteLine("{0}/{1}: quociente={2} e resto={3}", dividendo, divisor, quociente, resto);

            Console.ReadLine();
        }

        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    }
}
