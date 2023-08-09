using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_26_08_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int last;
            for (int i = 1; i <= 10;i++)
            {
                last = i * 5;
                Console.WriteLine("5 x {0} = {1}",i,last);
            }
            */

            int input_carpim, calc, last;
            Console.Write("Çarpım sayısı: ");
            input_carpim = int.Parse(Console.ReadLine());
            
            Console.Write("Limit: ");
            last = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= last; i++)
            {
                calc = i * input_carpim;
                //Console.Clear();
                Console.WriteLine("{0} x {1} = {2}", input_carpim, last, calc);
                
            }











            Console.ReadKey();                
        }
    }
}
