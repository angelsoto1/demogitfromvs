using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demogitfromvs
{
    class Program
    {
        static void Main(string[] args)
        {
            var saludo = new saludo();
            Console.WriteLine(saludo.Mensaje);

            Console.ReadLine();
        }
    }
}
