using System;

namespace CSLecture
{
    public class forloop
    {
        static void Main()
        {
            // write a program that print 20 * in one line
            // Print a triangle
            int dimension=0;
            Console.Write("Enter dimension:");
            dimension=int.Parse(Console.ReadLine());
            for(int h=1;h<=dimension;h++)
            {
                for(int spc=h; spc<dimension;spc++)
                {
                    Console.Write(" ");
                }
                for(int w=h;w<=(h*2-1); w++)
                {
                    Console.Write("* ");
                }
                    Console.WriteLine("");
            }




           /* for (int i=1; i<=20; i++)
            {
                Console.Write("*");
            }*/
            Console.ReadKey();
        }
    }
}