namespace GuessWhichNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessThatNumber();
        }

        static void GuessThatNumber()
        {
            Random rand = new();
            var randomNumber = rand.Next(0, 101);

            while (true)
            {
                var playerInput = Convert.ToInt32(Console.ReadLine());

                if (playerInput < randomNumber)
                {
                    Console.WriteLine($"Dessverre {playerInput} er for lavt");
                    continue;
                }
                else if (playerInput > randomNumber)
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