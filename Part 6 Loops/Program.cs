using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Loops
{
    class Program
    {   
        static void Main(string[] args)
        {
            int min;
            int max;
            int Inbetween;


            Console.WriteLine("Please enter a minimum value:");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a maximum value:");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter an integer that's inbetween your minimum and maximum values:");
            Inbetween = Convert.ToInt32(Console.ReadLine());
            // do
            //{

            // Console.WriteLine("Please enter an integer that's inbetween your minimum and maximum values:");
            // Inbetween = Convert.ToInt32(Console.ReadLine());

            //} while (Inbetween < MinInput);

            while (Inbetween < min || Inbetween > max)
            {
               
                
               Console.WriteLine("Please enter an integer that's inbetween your minimum and maximum values:");
               Inbetween = Convert.ToInt32(Console.ReadLine());

                
                

            }
            


            
            Console.WriteLine($"{Inbetween} is in between the maximum and minimum values!");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
         

            Console.ReadLine();
            








        }
    }
}
