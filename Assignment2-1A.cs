namespace Assignment2_1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user inputs
            Console.Write("Enter your Name: ");
            string userName = Console.ReadLine(); 

            Console.Write("Enter your Age: ");
            int userAge;

            //validation
            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.Write("Invalid Input. Please Enter a Valid Age: ");
            }

            //checking eligibility
            if (userAge >= 18)
            {
                Console.WriteLine($"Hi, {userName}! You are Eligible to Vote");
            }
            else
            {
                Console.WriteLine($"Sorry, {userName}! As you are only {userAge}, You are not eligible to vote");
            }
            //keep the console window open
            Console.ReadKey();
        }
    }
}
//read age of a candidate
//determine eligibility to vote
