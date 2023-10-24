static class WriteInfo
{
    public static void WelcomeScreen()
    {
        Console.WriteLine("Welcome to the Cesar's Game!");
        Console.WriteLine("1. Start a new game");
        Console.WriteLine("X. Close the program");
    }

    public static void WrongOption()
    {
        Console.WriteLine();
        Console.WriteLine("Wrong option, press enter to try again!");
    }

    public static void EnterHeroName()
    {
        Console.WriteLine("Enter the name of your character:");
    }

    public static void EnterHeroNameAgain()
    {
        Console.WriteLine("The name must contain alphabet letters and be at least 3 letters long. Please try again:");
    }

    public static void WelcomeHero(string heroName)
    {
        Console.Clear();
        Console.WriteLine("Welcome, " + heroName + "! Choose a character class from the following:");
    }

    public static void WrongClass()
    {
        Console.Clear();
        Console.WriteLine("No such option, choose again:");
    }

    public static void ChooseClass()
    {
        Console.WriteLine("1. Barbarian");
        Console.WriteLine("2. Paladin");
        Console.WriteLine("3. Amazon");
    }

    public static void StartAdventure(Hero hero)
    {
        Console.Clear();
        Console.WriteLine(hero.HeroClass + " " + hero.Name + " sets off on an adventure!");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    public static void ShowLocation(Location location)
    {
        for (int i = 0; i < location.npcs.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] Talk to {location.npcs[i].Name}");
        }

        Console.WriteLine("[X] Close");
    }
}
