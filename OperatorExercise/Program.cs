using System.Transactions;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int a = 17;
            int b = 4;

            int addSum = a + b;
            int diffSum = a - b;
            int multSum = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");*/



            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of a circle:" + AreaOfCircle(radius));
            

           



        }
        public static double AreaOfCircle(double radius)
        {

            return Math.PI * Math.Pow(radius, 2);
            
           
        }
    } }
