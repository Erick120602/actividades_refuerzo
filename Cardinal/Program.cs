using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardinal
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingrese el numero Cardinal : ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                string ordinal;

                if (i % 100 == 11 || i % 100 == 12 || i % 100 == 13)
                {
                    ordinal = i + "th";
                }
                else
                {
                    switch (i % 10)
                    {
                        case 1: ordinal = i + "st"; break;
                        case 2: ordinal = i + "nd"; break;
                        case 3: ordinal = i + "rd"; break;
                        default: ordinal = i + "th"; break;
                    }
                }

                Console.Write(ordinal + " ");
            }
            Console.ReadLine();
        }

    }

}

