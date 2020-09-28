using System;

namespace Part_6_Loops
{
    class Program
    {   
        static void Main(string[] args)
        {
            Random generator = new Random();

            int min;
            int max;
            int Inbetween;
            int percentage;
            double amount = 0;
            double above = 0;
            int n, lastnum, sum = 0;
            int minval;
            int maxval;
            int ran;
            //1
            Console.WriteLine("Please enter a minimum value:");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a maximum value:");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter an integer that's inbetween your minimum and maximum values:");
            Inbetween = Convert.ToInt32(Console.ReadLine());
           
            while (Inbetween < min || Inbetween > max)
            {
               
                
               Console.WriteLine("Please enter an integer that's inbetween your minimum and maximum values:");
               Inbetween = Convert.ToInt32(Console.ReadLine());

                
                

            }
            


            
            Console.WriteLine($"{Inbetween} is in between the maximum and minimum values!");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            //2

            do
            {
                Console.WriteLine("Please enter a percentage for a test score: ");
                Console.WriteLine("Enter 123 to submit");
                percentage = Convert.ToInt32(Console.ReadLine());

                if (percentage >= 70)
                {
                    amount += 1;
                    above += 1;
                    
                

                }
                else if (percentage < 70)
                {
                    amount += 1;

                }
                
                

            } while (percentage != 123);
           
            Console.WriteLine($"Your percentage of scores above 70 is {(above-1)/(amount-1) * 100}%");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            //3
            Console.WriteLine("Enter a number:");
            lastnum = Convert.ToInt32(Console.ReadLine());

            for (n = 1; n <= lastnum; n+= 2)
            {

                sum += n;

            }

            Console.WriteLine($"The sum of the odd numbers between 1 and {lastnum} is {sum}");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            //4

            Console.WriteLine("Please enter a minimum value: ");
            minval = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a maximum value: ");
            maxval = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 24; i++)
            {

                ran = generator.Next(minval, maxval);
                Console.WriteLine(ran);
            }











            Console.ReadLine();
            








        }
    }
}
