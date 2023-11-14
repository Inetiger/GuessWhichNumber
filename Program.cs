namespace VisualStudioEmne3
{
    internal class Program
    {
        private static string FullName = "Ine Nybø Botterli";
        private static bool Bypass = true;
        private static char TaskLoad = '3';

        //My tasks, fill in
        static List<string> Tasks = new() {
            "GuessWhichNumber",
            "alligatorGame",
            "TasteTest",
        };


        //Console Starts Main()
        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Hi, you have arrived at {FullName}'s C# tasks for StartIT Module 3");
            Console.WriteLine("Which task would you like to check out?");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] : {Tasks[i]}");
            }
            Console.WriteLine("---------------------------------");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please type in the task number ..");

            var taskChoice = Bypass ? TaskLoad : Console.ReadKey().KeyChar;


            //Check which task chosen, and run it
            switch (taskChoice)
            {
                case '1':
                    GuessWhichNumber.Load();
                    break;
                case '2':
                    alligatorGame.Load();
                    break;
                case '3':
                    TasteTest.Load();
                    break;
            }
        }
    }
}