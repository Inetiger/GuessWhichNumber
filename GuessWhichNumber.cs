namespace VisualStudioEmne3
{
    public class GuessWhichNumber
    {
        //Model


        //View
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have loaded into the task: GuessThatNumber!");
            Console.WriteLine("---------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            GuessThatNumber();
        }

        //Controls
        public static void GuessThatNumber()
        {
            Random rand = new();
            var randomNumber = rand.Next(0, 101);

            while (true)
            {
                var playerInput = Console.ReadLine();

                bool trueOrFalse = char.IsDigit(playerInput, 0);

                if (!trueOrFalse)
                {
                    Environment.Exit(1);
                }
                else
                {
                    var playerNumber = Convert.ToInt32(playerInput);
                    
                    if (playerNumber < randomNumber)
                    {
                        Console.WriteLine($"Dessverre {playerInput} er for lavt");
                        continue;
                    }
                    else if (playerNumber > randomNumber)
                    {
                        Console.WriteLine($"Dessverre {playerInput} er for høyt");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Hurra, det var riktig");
                        Console.WriteLine("Vil du prøve igjen y/n");
                        var yesOrNo = Console.ReadLine();
                        if (yesOrNo == "y")
                        {
                            GuessThatNumber();
                        }
                        else
                        {
                            Environment.Exit(1);
                        }
                    }
                }

            }
        }
    }
}