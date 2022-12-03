using System;
namespace CSLecture
{
    public class cs_funda
    {
        static void Main()
        {
            //how to declare variable

            // format  datatype identifier; or datatype indentifier = value;
            int numb1, numb2;
            // assign a value
            
            Console.Write("Enter first No.:");
            numb1= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second No.:");
            numb2= Convert.ToInt32(Console.ReadLine());

            // applying the arithmetic operation

            int sum= numb1 + numb2;
            int diff = numb1 - numb2;
            int prod= numb1 * numb2;
            double quo= numb1/ numb2;
            double rem= numb1 / numb2;
            numb1++;
            numb2--;
            Console.Write("New value of numb1:{0}\tNew Value of numb2:{1}", numb1, numb2);
           // Console.WriteLine("Sum: {0} \t Diff: {1} \t Prod: {2} \tQuotient: {3} \tRemainder: {4}", sum, diff, prod, quo, rem);

            //Console.WriteLine(numb);
            Console.ReadKey();

        }
    }
}