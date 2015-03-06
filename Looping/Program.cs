using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            int count = 0;
            do
            {

                Console.WriteLine(count);
                count++;
            } while (count < 10);



            //int count = 0;
            //while (count<10)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}
            Console.ReadKey();
        }
    }
}
