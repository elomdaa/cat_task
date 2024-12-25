
namespace ConsoleApp1
{
        class Program
        {
            static void Main(string[] args)
            {
                Authentication authSystem = new Authentication();
                int validtry = 3;

                while (validtry >0 )
                {
                    int test;
                    Console.WriteLine("choose: 1- for :Register\n 2- for Login\n 3- for Exit");
                    if (!int.TryParse(Console.ReadLine(), out test))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (test)
                    {
                        case 1:
                            authSystem.Register();
                            break;
                        case 2:
                            authSystem.Login();
                            break;
                        case 3:
                            Console.WriteLine("Exiting the system. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid command. Please try again.");
                            break;
                    }
                }
            }
        }
    } 
