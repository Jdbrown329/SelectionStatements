using System;

namespace SelectionStatements01
{
    class program
    {
        static void Main(string[]  args)
        {
            Console.WriteLine("Guess what my favorite number is:");
            int faveN = 33;
            
            int userInput= int.Parse( Console.ReadLine() );

            if (userInput > faveN)
            {
                Console.WriteLine("Too high!");
            }

            else if (userInput < faveN)
            {
                Console.WriteLine("Too low");
            }

            else if (userInput == faveN)
            {
                Console.WriteLine("Perfect, that's my fave number. GOOD JOB!" );
            }
         

        }
    }

}
