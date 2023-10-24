class GetInfo
{
    public static string GetHeroName()
    {
        string heroName;
        Console.Clear();
        WriteInfo.EnterHeroName();
        string input = Console.ReadLine();
        heroName = input.Replace(" ", "");


        while(heroName.Length <= 2 || !IsAlpha(heroName))
        {
            Console.Clear();
            WriteInfo.EnterHeroNameAgain();
            input = Console.ReadLine();
            heroName = input.Replace(" ", "");
        }

        return heroName;
    }

    public static EHeroClass GetHeroClass()
    {
        WriteInfo.ChooseClass();

        ConsoleKeyInfo keyInfo = Console.ReadKey();
        char command = keyInfo.KeyChar;

        while (command != '1' && command != '2' && command != '3')
        {
            WriteInfo.WrongClass();
            WriteInfo.ChooseClass();
            keyInfo = Console.ReadKey();
            command = keyInfo.KeyChar;
        }

        if (command == '1')
        {
            return EHeroClass.Barbarzynca;
        }
        else if (command == '2')
        {
            return EHeroClass.Paladyn;
        }
        return EHeroClass.Amazonka;
    }
    
    static bool IsAlpha(string heroName)
    {
        foreach (char i in heroName)
        {
            if (!char.IsLetter(i))
            {
                return false;
            }
        }
        return true;
    }
}