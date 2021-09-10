using System;

namespace CalcWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter two numbers separate with a space ie (10 2)");
            double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToDouble(arrTemp));
            
            

            caller c1 = new caller();
            c1.call(arr);
            Console.ReadLine();
        }        
    }
    public class caller
    {
        public void call(double[] arr)
        {
            double[] ArrayDouble = new double[4];
            string[] calc = { "addition:", "subtraction :", "Multipication :", "Divide :" };
            calc c = new calc();
            ArrayDouble[0] = c.add(arr[0], arr[1]);
            ArrayDouble[1] = c.subtraction(arr[0], arr[1]);
            ArrayDouble[2] = c.multiple(arr[0], arr[1]);
            ArrayDouble[3] = c.divide(arr[0], arr[1]);

            int i = 0;
            while (i < ArrayDouble.Length)
            {
                Console.Write(calc[i]);
                Console.WriteLine(ArrayDouble[i++]);
            }
        }        
    }

    class calc
    {
        private double num1;
        private double num2;
        private double result;

        public double Num1
        {
           get
           {
               return  num1;
           }
           set
           {
               this.num1 = value;
            }
        }
        public double Num2
        {
           get
           {
               return  num2;
           }
           set
          {
               this.num2 = value;
           }
        }
        public double Result
        {
            get
            {
            return  result;
            }
            set
            {
            this.result = value;
            }
        }
        public double add(double num1, double num2)
        {
            Result = Num1 + Num2;
            return Result;
        }
        public double subtraction(double num1, double num2)
        {
            Result = Num1 - Num2;
            return Result;
        }
        public double divide(double num1, double num2)
        {
            Result = Num1 / Num2;
            return Result;
        }
        public double multiple(double num1, double num2)
        {
            Result = Num1 * Num2;
            return Result;
        }
    }
}
