
class Game
{
    List<Location> locations = new List<Location>();

    void GenerateLocations()
    { 
        locations.Add(new Location("Calimport"));
        locations[0].AddNpc(new NonPlayerCharacter("Akara", Dialogs.Dialog1));
        locations[0].AddNpc(new NonPlayerCharacter("Charsi", Dialogs.Dialog2));

        locations.Add(new Location("Neverwinter"));
        locations[1].AddNpc(new NonPlayerCharacter("Deckard", Dialogs.Dialog1));
        locations[1].AddNpc(new NonPlayerCharacter("Cain", Dialogs.Dialog2));

        locations.Add(new Location("Silverymoon"));
        locations[2].AddNpc(new NonPlayerCharacter("Gheed", Dialogs.Dialog1));
        locations[2].AddNpc(new NonPlayerCharacter("Warriv", Dialogs.Dialog2));
    }

    void StartGame()
    {
        string heroName = GetInfo.GetHeroName();

        WriteInfo.WelcomeHero(heroName);

        EHeroClass heroClass = GetInfo.GetHeroClass();

        Hero myHero = new(heroName, heroClass);

        WriteInfo.StartAdventure(myHero);

        GenerateLocations();

        Play(myHero, locations[0]);
    }

    void Play(Hero hero, Location startLocation)
    {
        int option;

        Console.Clear();
        do
        {
            WriteInfo.ShowLocation(startLocation);
            int options = startLocation.npcs.Count;

            string opt = Console.ReadLine();

            if(opt == "X")
            {
                return;
            }

            if (int.TryParse(opt, out int number)) 
            {
                if(number > 0 && number <= options)
                {
                    option = number;
                    break;
                }
            }
            Console.WriteLine("Wrong option, please try again!");
            Console.Clear();

        } while (true);

        TalkTo(startLocation.npcs[option - 1], new DialogParser(hero));
    }

    void TalkTo(NonPlayerCharacter npc, DialogParser parser)
    {
        var dialogPart = npc.StartTalking();

        while(dialogPart != null)
        {
            Console.WriteLine(parser.ParseDialog(dialogPart));

            if(dialogPart.Responses == null)
            {
                break;
            }


            Console.WriteLine("What you want to say:");
            int i = 1;
            foreach(var res in dialogPart.Responses)
            {
                string text = parser.ParseDialog(res);
                Console.WriteLine($"  [{i++}] {text}");
            }

            int options = dialogPart.Responses.Length;
            do
            {
                var opt = Console.ReadLine();

                if (int.TryParse(opt, out int number))
                {
                    if (number > 0 && number <= options)
                    {
                        dialogPart = dialogPart.Responses[number - 1].Response;
                        break;
                    }
                }
            } while (true);
        }
    }

    public void Run()
    {
        char command;
        while (true)
        {
            Console.Clear();
            WriteInfo.WelcomeScreen();

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            command = keyInfo.KeyChar;

            switch (command)
            {
                case '1':
                    StartGame();
                    return;
                case 'X':
                    return;
                default:
                    WriteInfo.WrongOption();
                    Console.ReadLine();
                    break;
            }
        }
    }
}