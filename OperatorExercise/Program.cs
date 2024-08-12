namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // two integer variables
            int a = 17;
            int b = 4;

            // arithmetic operations
            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            // modulus operations
            int quotient = a / b;
            int remainder = a % b;

            // display results with string interpolation
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            //Part 2: Asking for radius of 5
            Console.WriteLine("Please input the radius value for a circle:");
            double radius = double.Parse(Console.ReadLine());
            double answer = AreaofCircle(radius);
            Console.WriteLine($"The value of the area of the circle is {answer}");
            
        }

        //Method for AreaofCircle
        static double AreaofCircle(double radius)
        {
            // Math.PI * Math.Pow(radius, 2);
            return (Math.PI * Math.Pow(radius, 2));
        }
    }
}
