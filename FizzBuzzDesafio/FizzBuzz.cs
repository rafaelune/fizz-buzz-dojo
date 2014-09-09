using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzDesafio
{
    public class FizzBuzz
    {
        public string Verificar(int p)
        {
            if ((p % 15) == 0)
            {
                return "Fizz Buzz";
            }
            else if ((p % 3) == 0)
            {
                return "Fizz";
            }
            else if ((p % 5) == 0)
            {
                return "Buzz";
            }

            return p.ToString();
        }
    }
}
