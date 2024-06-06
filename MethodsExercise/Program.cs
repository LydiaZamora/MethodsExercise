namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();

            int added = Add(2, 2);
            Console.WriteLine(added);

            int subtracted = Subtract(18, 5);
            Console.WriteLine(subtracted);

            int multiplied = Multiply(6, 11);
            Console.WriteLine(multiplied);

            int divided = Divide(30, 3);
            Console.WriteLine(divided);

            int mod = Modulus(130, 5);
            Console.WriteLine(mod);

            int result = Sum(5, 5, 5, 5, 5, 5);
            Console.WriteLine(result);
        }

        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"{userName} was at a {favBand} concert when a {favAnimal} ran into the ampitheatre wearing {favoriteColor} sunglasses.");
        }


        // -----------------Exercise 2-------------------

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
             
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }


        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }


        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Modulus(int numOne, int numTwo)
        {
            return numOne % numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
