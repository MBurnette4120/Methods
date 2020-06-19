using System;

namespace MethodExercise
{
    class Program
    {
        //Make sure you do not put a method inside of a method!!

        //<access modifier> <return type> <descriptive method name> <(parameter list)>
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;



        }
        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;

        }
        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;



        }
        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number");
            var num2 = int.Parse(Console.ReadLine());


            var answer = Sum(num1, num2);
            Console.WriteLine($"The Answer is {answer}");


            /*Console.WriteLine("Give me a number");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number");
            var num2 = int.Parse(Console.ReadLine());

            var answer = Divide(num1, num2);
            Console.WriteLine($"The Answer is {answer}");

            */

            /*
            Console.WriteLine("Give me a number");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number");
            var num2 = int.Parse(Console.ReadLine());

            var answer = Subtract(num1, num2);
            Console.WriteLine($"The Answer is {answer}");

            */

            /*

            Console.WriteLine("Give me a number");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number");
            var num2 = int.Parse(Console.ReadLine());

            var answer = Multiply(num1, num2);
            Console.WriteLine($"The Answer is {answer}");

            */
        }
    }
}
