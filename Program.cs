using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloader
{
    class Program
    {

        public class Math
        {
            public int Area(int l, int b)
            {
                return l * b;
            }

            public int Area(int a)
            {
                return a * a;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine(@"
      ___           ___           ___           ___           ___                       ___     
     /\__\         /\  \         /\  \         /\  \         /\  \                     /\__\    
    /:/  /        /::\  \        \:\  \       /::\  \       /::\  \         ___       /:/ _/_   
   /:/  /        /:/\:\  \        \:\  \     /:/\:\  \     /:/\:\__\       /|  |     /:/ /\  \  
  /:/  /  ___   /:/ /::\  \   _____\:\  \   /:/ /::\  \   /:/ /:/  /      |:|  |    /:/ /::\  \ 
 /:/__/  /\__\ /:/_/:/\:\__\ /::::::::\__\ /:/_/:/\:\__\ /:/_/:/__/___    |:|  |   /:/_/:/\:\__\
 \:\  \ /:/  / \:\/:/  \/__/ \:\~~\~~\/__/ \:\/:/  \/__/ \:\/:::::/  /  __|:|__|   \:\/:/ /:/  /
  \:\  /:/  /   \::/__/       \:\  \        \::/__/       \::/~~/~~~~  /::::\  \    \::/ /:/  / 
   \:\/:/  /     \:\  \        \:\  \        \:\  \        \:\~~\      ~~~~\:\  \    \/_/:/  /  
    \::/  /       \:\__\        \:\__\        \:\__\        \:\__\          \:\__\     /:/  /   
     \/__/         \/__/         \/__/         \/__/         \/__/           \/__/     \/__/    
                                                
                                [ Developer : Saurabh Agarwal ]
                                [ Developer : Blesslin Jerish R ]
                                    [ Stack : c# .net ]
                              ");
            Console.WriteLine("");
            Console.WriteLine("Bonjour Canarys");
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine("");

            // objectify
            Math ar = new Math();
        start:
            Console.WriteLine("Rectangle or Square ? ");
            Console.WriteLine(@"
1. Rectangle
2. Square
3. Both
4. none of the above
");
            int opt = Convert.ToInt32(Console.ReadLine());
            if(opt == 1)
            {
                Console.WriteLine("Enter Length : ");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Breadth : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Our Area");
                Console.WriteLine($"I am Rectangle : {ar.Area(l,b)}");
            }
            else if(opt == 2)
            {
                Console.WriteLine("Enter Side : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Our Area");
                Console.WriteLine($"I am Square : {ar.Area(a)}");
            }
            else if(opt == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Rectangle");
                Console.WriteLine("Enter Length : ");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Breadth : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Our Area");
                Console.WriteLine($"I am Rectangle : {ar.Area(l,b)}");
                Console.WriteLine("");
                Console.WriteLine("Square");
                Console.WriteLine("Enter Side : ");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Our Area");
                Console.WriteLine($"I am Square : {ar.Area(a1)}");
            }
            else
            {
                Console.WriteLine("Get a life Bruh.");
            }
            Console.WriteLine("");
            Console.WriteLine("Miss me ? Press Me .");
            Console.WriteLine("");
            Console.ReadLine();
            goto start;
        }
    }
}
