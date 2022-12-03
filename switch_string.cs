using System;

namespace CSLecture
{
    public class cs_switch
    {

        static void Main()
        {
           //using switch

           string celebName;

           Console.WriteLine("Enter the Name to Check");
           celebName= Convert.ToString(Console.ReadLine());

            switch(celebName)
            {
                case "Zoraida":
                case "zoraida":
                    Console.WriteLine("Nagalas nga babae!");
                    break;
                case "Mia Khalifa":
                case "mia khalifa":
                    Console.WriteLine("Nalaeng agsal-la!");
                    break;
                case "Julia":
                case "julia":
                    Console.WriteLine("Ganda mo gurl");
                    break;
                default:
                    Console.WriteLine("Ate! Wag shunga sa pag-enter!");
                    break;
            }


            Console.ReadKey();
        }
    }

}