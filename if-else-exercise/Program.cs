namespace if_else_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());


            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizzbuzz!");
            }
            else if(number % 3 == 0)
            {
                Console.WriteLine("Fizz!");
            }
            else if(number % 5 == 0)
            {
                Console.WriteLine("Buzz!");   
            }
            else
            {
                Console.WriteLine("Otherwise"); 
            }
        }
    }
}
