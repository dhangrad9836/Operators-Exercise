namespace OperatorExercise
{
    public class Program
    {

        //area of a circle method use formula Math.PI * Math.Pow(radius, 2);
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static void Main(string[] args)
        {
            //Exercise 1
            //Create 2 integer variables.
            int a = 17;
            int b = 4;

            //Write out operations for addition, subtraction, and multiplication
            //addition
            int sum = a + b;

            //subtracion
            int difference = a - b;

            //multiplication
            int product = a * b;

            //division and modulus
            int quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            //Exercise 2 Calculate the area of a circle
            //get input from user for radius
            Console.WriteLine("What is the radius of your circle?");
            //store user input in radius variable
            double radius = double.Parse(Console.ReadLine());
            //call AreaOfCircle with radius value
            Console.WriteLine(AreaOfCircle(radius));

            // var is implicit type inferrence (more on this later)
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            
            //value of k will be 16 since ++i will be incremented by one instantly making it 4
            //and j++ has a post-increment operator so the current value remains the same and will
            //be updated or increased by one for the next execution
            Console.WriteLine(k); // ouputs ?

            Console.ReadLine();

        }
    }
}
