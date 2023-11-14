namespace VisualStudioEmne3
{
    public class alligatorGame
    {
        //Model


        //View
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have loaded into the task: alligatorGame!");
            Console.WriteLine("---------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            int gameScore = 0;
            AligatorGame(gameScore);
        }


        public static void AligatorGame(int gameScore)
        {
            Random rand1 = new Random();
            Random rand2 = new Random();
            int randomNumber1 = rand1.Next(0, 11);
            int randomNumber2 = rand2.Next(0, 11);
            Console.WriteLine($"Hva er størst av {randomNumber1}_{randomNumber2}");
            string playerInput = Console.ReadLine();

            switch (playerInput)
            {
                case "<":
                    if (randomNumber1 < randomNumber2)
                    {
                        Console.WriteLine("Riktig");
                        gameScore++;

                    }
                    else
                    {
                        Console.WriteLine("Feil");
                        gameScore--;
                    }

                    Console.WriteLine(gameScore);
                    AligatorGame(gameScore);
                    break;
                case ">":
                    if (randomNumber1 > randomNumber2)
                    {
                        Console.WriteLine("Riktig");
                        gameScore++;
                    }
                    else
                    {
                        Console.WriteLine("Feil");
                        gameScore--;
                    }

                    Console.WriteLine(gameScore);
                    AligatorGame(gameScore);
                    break;
                case "=":
                    if (randomNumber1 == randomNumber2)
                    {
                        Console.WriteLine("Riktig");
                        gameScore++;
                    }
                    else
                    {
                        Console.WriteLine("Feil");
                        gameScore--;
                    }

                    Console.WriteLine(gameScore);
                    AligatorGame(gameScore);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }
    }
}