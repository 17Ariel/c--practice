using System;

namespace CSLecture
{
    public class cs_switch
    {

        static void Main()
        {
           //using switch

           char Remark;

           Console.WriteLine("Enter your grade Remark");
           Remark= Convert.ToChar(Console.ReadLine());

            switch(Remark)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Nag-brainy ka ante!!!");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Nag-Keri ti Utak Mes!!!");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Nag-pintas ka Ante!!! :) ");
                    break;
                case 'F':
                case 'f':
                    Console.WriteLine("Apay nag bobits ka, ag adal ka nalalaeng!!!");
                    break;
                default:
                    Console.WriteLine("Ate! Wag shunga sa pag-enter!");
                    break;
            }


            Console.ReadKey();
        }
    }

}