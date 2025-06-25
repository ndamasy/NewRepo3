namespace assignment_c_sharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region takes a number from the user
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            //convert string to integer
            int number = int.Parse(input);
            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {

                Console.WriteLine("No");
            }

            #endregion


            #region allows the user to insert an integer
            Console.WriteLine("please insert an integer");
            string input = Console.ReadLine();
            //convert string to integer
            int integer = int.Parse(input);
            //check if the number is positive or negative
            string message = integer >= 0 ? "The number is positive" : "The number is negative";
            Console.WriteLine(message);
            #endregion


            #region takes 3 integers from the user
            Console.WriteLine("insert 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insert 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("insert 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            int max = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine("The max number is: " + max);
            int min = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine("The min number is: " + min);
            #endregion


            #region check If a number is even or odd
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            // Convert string to integer
            int number = int.Parse(input);
            // Check if the number is even or odd
            string result = number % 2 == 0 ? "number is even" : "number is odd";
            Console.WriteLine(result);
            #endregion


            #region takes character from the user
            Console.WriteLine("Please enter a character:");
            string input = Console.ReadLine();
            // Check if the input is a vowel character
            switch (input)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("The character is a vowel.");
                    break;
                default:
                    Console.WriteLine("The character is not a vowel.");
                    break;
            }
            #endregion


            #region enter marks of five subjects
            Console.WriteLine("Enter mark for 1st subject:");
            int subject1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark for 2nd subject:");
            int subject2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark for 3rd subject:");
            int subject3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark for 4th subject:");
            int subject4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark for 5th subject:");
            int subject5 = int.Parse(Console.ReadLine());
            // Calculate total and average
            int total = subject1 + subject2 + subject3 + subject4 + subject5;
            Console.WriteLine("Total marks: " + total);
            // Calculate average
            double average = total / 5;
            Console.WriteLine("Average marks: " + average);
            // Determine grade based on average
            double percentage = ((double)total / 500) * 100;
            Console.WriteLine("Percentage: " + percentage + "%");
            #endregion


            #region input the month number and print the number of days
            Console.WriteLine("Enter month number (1 to 12):");
            int month = int.Parse(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1:  // January
                case 3:  // March
                case 5:  // May
                case 7:  // July
                case 8:  // August
                case 10: // October
                case 12: // December
                    days = 31;
                    break;

                case 4:  // April
                case 6:  // June
                case 9:  // September
                case 11: // November
                    days = 30;
                    break;

                case 2:  // February
                    days = 28; // Assuming not a leap year
                    break;

                default:
                    Console.WriteLine("Invalid month number. Please enter a number from 1 to 12.");
                    return;
            }

            Console.WriteLine($"Month {month} has {days} days.");

            #endregion


            #region Write a program to create a Simple Calculator
            Console.WriteLine("Simple Calculator");

            // Input first number
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            // Input operator
            Console.Write("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            // Input second number
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result;

            // Perform calculation
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                    break;
            }
            #endregion
        }
    }
}
