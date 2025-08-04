namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            } 
        }
        
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static void TwoNumbers()

        {
            Console.WriteLine("Choose a Number");
           int numOne = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Choose a Second Number");
           int numTwo = Convert.ToInt32(Console.ReadLine());
            bool areNumbersEqual; 
            if (numOne == numTwo)
            {
                Console.WriteLine($"{numOne} and {numTwo} are the same!");
                areNumbersEqual = true;

            }
            else
            {
                Console.WriteLine($"{numOne} and {numTwo} are not the same!");
                areNumbersEqual = false;
                
            }
        }
        
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static void EvenOrOdd()
        {
            bool isEven;
            Console.WriteLine("Choose a Number");
            int evenOrOddInput = Convert.ToInt32(Console.ReadLine());
            
            if (evenOrOddInput % 2 == 0)
            {
                Console.WriteLine("Even");
                isEven = true;
            }
            else
            {
                Console.WriteLine("Odd");
                isEven = false;
            }
        }
        
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static void PositiveNumber()
        {
            Console.WriteLine("Choose a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPositive;

            if (number > 0)
            {
                Console.WriteLine("This Number is Positive");
                isPositive = true;
            }
            else
            {
                Console.WriteLine("This Number is Negative");
                isPositive = false;
            }
            
            
        }
        
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static void CanVote()
        {
            bool canVote;
            Console.WriteLine("Please Enter your Age:");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);


            while (canParse == false)
            {
                Console.WriteLine("Please Enter a Valid Age:");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }

            if (userAge >= 18)
            {
                Console.WriteLine($"Congrats, {userAge} is old enough to vote!");
                canVote = true;
            }
            else
            {
                Console.WriteLine($"Sorry, {userAge} is not old enough to vote!");
                canVote = false;
            }

        }
        
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static void Range()
        {
            bool IsInRange;
            Console.WriteLine("Please Enter a Number:");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);

            while (!canParse)
            {
                Console.WriteLine("Please Enter a Valid Number:");
                canParse = int.TryParse(Console.ReadLine(), out userNumber);
            }

            if (userNumber <= 10 && userNumber >= -10)
            {
                Console.WriteLine($"{userNumber} is in ten range!");
                IsInRange = true;

            }
            else
            {
                Console.WriteLine($"{userNumber} is not in ten range!");
                IsInRange = false;
            }
            
        }
        
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"


        public static void DisplayMultiplcationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintEveryThirdNumber();
            TwoNumbers();
            EvenOrOdd();
            PositiveNumber();
            CanVote();
            Range();
            DisplayMultiplcationTable(11);
        }
    }
}
