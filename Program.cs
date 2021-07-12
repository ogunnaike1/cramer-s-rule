using System;
/*
NAME: OGUNNAIKE USMAN OLUSEGUN
MATRIC NO: EES/18/19/0377
ELECT /ELECT


*/

namespace us
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine ("enter a,b,c,d,e and f");

            

                double a,b,c,d,e,f;
                a =Convert.ToDouble(Console.ReadLine());
                b =Convert.ToDouble(Console.ReadLine());
                c =Convert.ToDouble(Console.ReadLine());
                d =Convert.ToDouble(Console.ReadLine());
                e =Convert.ToDouble(Console.ReadLine());
                f =Convert.ToDouble(Console.ReadLine());
                double determinant= (a*b)- (b*c);
                double changeinx= (e*d)- (b*f);
                double changeiny= (a*f)- (e*c);

                if(determinant == 0)
                Console.WriteLine("the equation has no soltion");

                else{ 
                    double x = changeinx/determinant;
                    
                    double y = changeiny/determinant;

                    Console.WriteLine(" x is" + x);
                    Console.WriteLine(" and y is" + y);

                }
              
               


                
        }
    }
}
