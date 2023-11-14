namespace VisualStudioEmne3
{
    public class TasteTest
    {
        //Model


        //View
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have loaded into the task: TasteTaste!");
            Console.WriteLine("---------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            tasteTest();
        }

        public static void tasteTest()
        {
            int something = 0;
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                string lowerCaseString = text.ToLower();
                foreach (var character in lowerCaseString ?? string.Empty)
                {
                    counts[(int)character]++;
                    something += counts[(int)character];
                }

                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var percentage = 100 * (double)counts[i] / something;
                        string output = character + " - " + percentage.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1; //This was a massive loss, I had to look it up, and i don't know how i could have found this myself.
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}