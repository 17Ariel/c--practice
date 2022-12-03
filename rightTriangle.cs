using System;
namespace CSLecture
{
    public class rightTriangle
    {
        static void Main()
        {
            int row=5;
            for(int i=1; i<=row;i++)
            {
                for(int j=1;j<=i; j++)
                {
                    Console.Write("* ");
                }
                    Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}