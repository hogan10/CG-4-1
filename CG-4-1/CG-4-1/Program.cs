using System;

namespace CG_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //First we have to get a value from the user, so we ask
            Console.Write("Please enter any number: ");

            //We have to make sure they enter a number for this to
            //work so we conver to an int. We aren't worried about 
            //decimals so we can just use parse. If this was division
            //then I would worry about using the decimal

            string userValue = Console.ReadLine();
            int Value = int.Parse(userValue);

            int total = 0;

            //We create the loop beginning at 2 and go to 20
            for (int i = 2; i < 21; i++)

            {
                //Here we tell the program what to do with the user value
                Console.WriteLine(i * Value);
                //Now that the loop is finished we need the sum

               total += i * Value;
            }

            //Now we write/show the total
            Console.Write(total);
            Console.ReadLine();
        }
    }
}
