using System;

namespace Capstone_Methods
{
    class Program
    {
        //Declaring our method for our mathical operatorations
        static void Arithmetic(int first, int second, string punctuation)
        {

            Console.WriteLine(first + punctuation + second);
            //We are using a switch statement to make sure the user is able to enter our specfic operators
            //Then we are going to print the calculations after the user enters the numbers.
            switch (punctuation)
            {
                case "+":
                    {
                        int ans = first + second;
                        Console.WriteLine(ans);
                      
                    }
                    break;
                case "-":
                    {
                        int ans = first - second;
                        Console.WriteLine(ans);
                    }
                    break;
                case "*":
                    {
                        int ans = first * second;
                        Console.WriteLine(ans);
                    }
                    break;
                case "/":
                    {
                        float ans = (float)first / (float)second;
                        Console.WriteLine(ans);
                    }
                    break;
            }

        }
        static void Main(string[] args)
        {
            //We are declaring our variables to be used in our program
            bool exitPrgram = false;
            string number1 = "";
            string number2 = "";
            string op = "";
            bool pass = true;

            int first, second;
            //While this is true print these introductions to the user on the console.
            while (true)
            {
                pass = true;

                Console.WriteLine("Kenneth Ellington");
                Console.WriteLine("Please enter Exit to leave program.");
                Console.WriteLine("Please enter first whole interger number.");
                //We are taking the user input for the first number
                number1 = Console.ReadLine();
                if (number1.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine("Please enter second whole interger number.");
                //Taking the users input for the second number 
                number2 = Console.ReadLine();
                if (number2.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine("Please enter math operation [+,-,*,/]");
                //Taking the the user input for the operrand 
                op = Console.ReadLine();
                if (op.ToLower() == "exit")
                {
                    break;
                }

                //Converting the users value into intger from a string for each number they entered. 
                if (int.TryParse(number1, out first) == false)
                {
                    Console.WriteLine("The first value entered was not a number. Reenter value");
                    pass = false;
                }

                if (int.TryParse(number2, out second) == false)
                {
                    Console.WriteLine("The second value entered was not a number. Reenter value");
                    pass = false;
                }

                if (op != "+" && op != "-" && op != "*" && op != "/")
                {
                    Console.WriteLine("The operator entered was not [+,-,*,/]");
                    pass = false;
                }

                if (op == "/" && second == 0)
                {
                    Console.WriteLine("Divide by zero detected please reenter");
                    pass = false;
                }

                if(!pass)
                {
                    continue;
                }

                //Calling the method to be run.
                Arithmetic(first, second, op);
            }
        }
        
    }
}
