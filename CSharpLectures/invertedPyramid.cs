using System;
namespace CSLecture
{
    public class invertedPyramid
    {
        static void Main()
        {
            int n, i, j;

            Console.WriteLine("Enter number of rows: ");
            n=int.Parse(Console.ReadLine());

           /* for(i = 1; i <= n; i++)
                {
                 //print * equal to row number
                 for(j = 1; j <= i; j++)
                    {
                    Console.Write("* ");
                    }   
                    Console.WriteLine("");
                } */

                
                for(i = 1; i <= n; i++)
                {
                 //print * equal to row number
                 for(int spc=i; spc<=n-1;spc++)
                 {
                     Console.Write("  "); // double space
                 }
                 for(j = 1; j <= (2*i-1); j++)
                    {
                    Console.Write("* "); //printing * with 1 space
                    }   
                    Console.WriteLine("");
                }
         Console.ReadKey();       
        }
    }
}