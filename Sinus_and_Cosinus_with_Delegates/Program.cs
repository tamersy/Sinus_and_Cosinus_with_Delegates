using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinus_and_Cosinus_with_Delegates
{
    class MathFunction
    {
        //Function for Sinus
        public string Sinus(double Number)
        {
            return string.Format($"Sin({Number}) = {Math.Sin(Number)}");
        }

        //Function for Cosinus
        public string Cosinus(double Number)
        {
            return string.Format($"Cos({Number}) = {Math.Cos(Number)}");
        }
    }

    //The delegate
    public delegate string Functions(double Num);

    class Program
    {
        static void Main(string[] args)
        {
            //Input the number
            Console.WriteLine("Enter a number :");
            double Num = Convert.ToDouble(Console.ReadLine());

            //Object from MathFunction class
            MathFunction function = new MathFunction();

            //Objects from Functions delegate
            Functions F1 = new Functions(function.Sinus);
            Functions F2 = new Functions(function.Cosinus);

            //Print Sinus and Cosinus
            Console.WriteLine(F1(Num));
            Console.WriteLine(F2(Num));

            //Stop screen
            Console.ReadKey();
        }
    }
}
