using System;
namespace CSLecture
{
    class pyramid
    {
        static void Main()
        {
            int row;
            Console.Write("Enter row of pyramid:");
            row= int.Parse(Console.ReadLine());

          /*  //first for loop determines the row or height
            for(int i=1; i<=row; i++)
            {
                //this loop for spaces
                for(int spc=i; spc<=row-1; spc++)
                {
                    Console.Write("  ");// printing spaces
                }

                //this loop prints the *
                for(int j=1; j<=(2*i-1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }*/

            //first for loop determines the row or height
            for(int i=row; i>=1; i--)
            {
                //this loop for spaces
                for(int spc=i; spc<=row-1; spc++)
                {
                    Console.Write("  ");// printing spaces
                }

                //this loop prints the *
                for(int j=1; j<=(2*i-1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }

}