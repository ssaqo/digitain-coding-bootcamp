using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public delegate void Mydelegate();

        static void Main(string[] args)
        {
            var d1 = new Mydelegate(F1);
            Mydelegate d2 = F1;
            Mydelegate d3 = null;
            d3 = d1 + d2;

            Function(d1);
            Function(d2);
            Function(d3);

        }
        static void F1()
        {
            Console.WriteLine("F1");
            Console.ReadLine();
        }

        static void Function(Mydelegate d)
        {
            if (d == null)
            {
                throw new ArgumentNullException(nameof(d));
            }
            d();
        }
    }
}
