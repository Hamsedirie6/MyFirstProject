using System;

namespace EnkelKalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fortsätt = true;

            while (fortsätt)
            {
                try
                {
                    Console.WriteLine("Enkel Kalkylator");
                    Console.WriteLine("Välj operation (+, -, *, /): ");
                    char operation = Console.ReadKey().KeyChar;

                    Console.WriteLine("\nAnge första talet: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ange andra talet: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (operation)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 == 0)
                            {
                                Console.WriteLine("Fel: Division med noll är ej tillåten.");
                                continue;
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Ogiltig operation. Försök igen.");
                            continue;
                    }

                    Console.WriteLine($"\nResultat: {result}");

                    // Fråga om användaren vill göra fler beräkningar
                    Console.WriteLine("\nVill du göra en ny beräkning? (j/n)");
                    string svar = Console.ReadLine().ToLower();
                    if (svar != "j")
                    {
                        fortsätt = false;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Fel: Ogiltig inmatning. Vänligen ange numeriska värden.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ett oväntat fel inträffade: {ex.Message}");
                }
            }

            Console.WriteLine("Tack för att du använde kalkylatorn!");
        }
    }
}

