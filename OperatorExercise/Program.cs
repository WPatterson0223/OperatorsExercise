namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a = 17;
            int b = 4;

            x = a + b;
            x = a - b;
            x = a * b;
            x = a / b;
            x = a % b;

            int quotient = a / b;
            int remainder = a % b;

            if(a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            //Console.WriteLine("What is the radius of your circle?");
            //var radius = double.Parse(Console.ReadLine());
            //double area = AreaOfCircle(radius);

            //Console.WriteLine($"The area of a circle with radius of {radius} id {area}");

            
        }


        //static double AreaOfCircle(double radius)
        //{
        //    return Math.PI * Math.Pow(radius, 2);
        //}
    }
}
