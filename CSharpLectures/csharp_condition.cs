using System;

namespace CSLecture
{
    public class csharp_condition
    {

        static void Main()
        {
            // The program should ask to enter your final grade. The should tell your remarks
            /*
                90-100 : excellent
                80-90: Very Satisfactory
                75-79: Good
                0-74: Failed
             */

            int grade=0;

            Console.WriteLine("Enter your final grade:");
            grade=int.Parse(Console.ReadLine()); // variable value assignment

            // we are going to use if...else statement

            if (grade>=90 && grade<=100)
            {
                Console.WriteLine("EXCELLENT");
            }
            else if(grade>=80 && grade<=89)
            {
                Console.WriteLine("VERY SATISFACTORY");
            }
            else if(grade>=75 && grade<=79)
             {
                Console.WriteLine("Good");
            }
            else if (grade<75 && grade >=0)
            {
                 Console.WriteLine("Failed");
            }
            else if(grade< 0 || grade >100)
            {
                 Console.WriteLine("invalid grade entry");
            }
            
            
            //grade=Convert.ToInt32(Console.ReadLine());




            Console.ReadKey();
        }
    }

}