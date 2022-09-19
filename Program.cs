using System;

namespace unlimitedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of numbers that will be entered into " +
                "the program.");
            string line = Console.In.ReadLine();

            decimal size;
            if (!Decimal.TryParse(line, out size))
            // This if statement is to ensure that the user provides mumeric
            // input only by ignoring any input that is non-numeric.
            {
                Console.WriteLine("Please enter the amount of numbers that will " +
                    "be entered into the program.");
                Console.In.ReadLine();
            }
            
            Console.WriteLine("Please enter the numbers that will appear " +
                "in the list.");
                decimal[] numbers = new decimal[(int)size];
            // the numbers array will hold the array that will accept the size
            // and numbers that the user provides.


            while (true)
                // the while(true) loop will allow the user to run through the program
                // as many times as they like.
                {
                    for (int i = 0; i < numbers.Length; i++)
                    // the for loop will accept the the numbers that user inputs
                    // while storing the size that user provided and will increase
                    // incrementially until the array reaches the size provided.
                    {
                    try
                    // this trycatch exception is meant to prevent users from
                    // giving non-nmeric input when the program asks for the
                    // numbers that will go into the array.
                    {
                        numbers[i] = Convert.ToDecimal(Console.In.ReadLine());
                    }
                    catch(FormatException) {
                        Console.WriteLine("Please enter the numbers that will appear " +
                            "in the list.");
                        numbers[i] = Convert.ToDecimal(Console.In.ReadLine());
                    }


                }
                        for (int i = 0; i < numbers.Length; i++)
                        // this for loop will output the numbers that the user has provided
                        // once the array is filled.
                        {
                            Console.Write(numbers[i] + "," + " ");
                             numbers = numbers.TrimEnd(",");
                        }
                        Console.WriteLine(Environment.NewLine + "Do you wish to run the program again, " +
                               "please say yes or no?");
                        string input = Console.ReadLine();
                        if (input == "no")
                        // This if loop will allow the user to end the program if they
                        // are done entering numbers.
                        {
                            Console.WriteLine("Thank for using this program, have a " +
                                "nice day.");
                            break;
                        }
                }
            }
        }
    }


