namespace New_5_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                ShowColor();
            }
            static void ShowColor()
            {
                int i = 1;
                while (true)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("\nIteration {0}", i);

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Enter your color: ");
                    string color = new(Console.ReadLine());
                    if (color == "stop")
                    {
                        Console.WriteLine("The circle has been stopped");
                        break;
                    }
                    switch (color)
                    {
                        case "red":
                            Console.BackgroundColor = ConsoleColor.Red; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                            Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                            Console.WriteLine("Your color is " + color);
                            break;


                        case "yellow":
                            Console.BackgroundColor = ConsoleColor.Yellow; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                            Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                            Console.WriteLine("Your color is " + color);
                            break;

                        case "green":
                            Console.BackgroundColor = ConsoleColor.Green; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                            Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                            Console.WriteLine("Your color is " + color);
                            break;

                        case "blue":
                            Console.BackgroundColor = ConsoleColor.Blue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                            Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                            Console.WriteLine("Your color is " + color);
                            break;

                        case "dark blue":
                            Console.BackgroundColor = ConsoleColor.DarkBlue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                            Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                            Console.WriteLine("Your color is " + color);
                            break;

                        case "violet":
                            Console.BackgroundColor = ConsoleColor.DarkMagenta; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                            Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                            Console.WriteLine("Your color is " + color);
                            break;

                        case "cyan":
                            Console.BackgroundColor = ConsoleColor.Cyan; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                            Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                            Console.WriteLine("Your color is " + color);
                            break;

                        case "white":
                            Console.BackgroundColor = ConsoleColor.White; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                            Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                            Console.WriteLine("Your color is " + color);
                            break;

                        default:
                            Console.BackgroundColor = ConsoleColor.Yellow; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sorry color {0} not found in database", color);
                            break;


                    }
                    i++;
                }
                Console.ReadKey();
            }
        }
    }
}