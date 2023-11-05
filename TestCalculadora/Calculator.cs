using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculadora
{
    public class DeepThought_From_the_Hitchhikers_guide_to_the_galaxy
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Nonono, can't divide by zero in our universe.");

            return a / b;
        }

        public string UltimateQuestion(string question = "What is the meaning of life, the universe, and everything?")
        {
            Console.WriteLine("Have to think about it... Come back in 7.5 million years.");

            // In theory, we would sleep the thread for 7.5 million years here.
            // But in practice, we'll just sleep for a second instead.
            // Chatting with bing, it told me the compiler won't let me just put the method into a for loop, so thats it.. sleep for 24 days.
            Thread.Sleep(2147483600);

            return "The answer is: 42";
        }
    }
}