
using System;

namespace EnkelKalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabel för att kontrollera om användaren vill fortsätta
            bool fortsätt = true;

            // Huvudloop som körs så länge användaren vill fortsätta
            while (fortsätt)
            {
                try
                {
                    // Skriver ut kalkylatorns titel
                    Console.WriteLine("Enkel Kalkylator");
                    Console.WriteLine("Välj operation (+, -, *, /): ");
                    // Läser in användarens val av operation
                    char operation = Console.ReadKey().KeyChar;

                    // Begär det första talet från användaren
                    Console.WriteLine("\nAnge första talet: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    // Begär det andra talet från användaren
                    Console.WriteLine("Ange andra talet: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    // Variabel för att lagra resultatet av operationen
                    double result = 0;

                    // Bestämmer vilken operation som ska utföras
                    switch (operation)
                    {
                        case '+':
                            result = num1 + num2; // Addition
                            break;
                        case '-':
                            result = num1 - num2; // Subtraktion
                            break;
                        case '*':
                            result = num1 * num2; // Multiplikation
                            break;
                        case '/':
                            // Kontrollera division med noll
                            if (num2 == 0)
                            {
                                Console.WriteLine("Fel: Division med noll är ej tillåten.");
                                continue; // Gå tillbaka till början av loopen
                            }
                            result = num1 / num2; // Division
                            break;
                        default:
                            // Hantera ogiltiga operationer
                            Console.WriteLine("Ogiltig operation. Försök igen.");
                            continue; // Gå tillbaka till början av loopen
                    }

                    // Skriver ut resultatet av operationen
                    Console.WriteLine($"\nResultat: {result}");

                    // Fråga om användaren vill göra fler beräkningar
                    Console.WriteLine("\nVill du göra en ny beräkning? (j/n)");
                    string svar = Console.ReadLine().ToLower();
                    // Om svaret inte är 'j', avsluta loopen
                    if (svar != "j")
                    {
                        fortsätt = false; // Sätt fortsätt till false för att avsluta loopen
                    }

                }
                catch (FormatException)
                {
                    // Hantera ogiltig inmatning
                    Console.WriteLine("Fel: Ogiltig inmatning. Vänligen ange numeriska värden.");
                }
                catch (Exception ex)
                {
                    // Hantera oväntade fel
                    Console.WriteLine($"Ett oväntat fel inträffade: {ex.Message}");
                }
            }

            // Meddelande när programmet avslutas
            Console.WriteLine("Tack för att du använde kalkylatorn!");
        }
    }
}
