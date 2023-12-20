class Cities
{
    private List<string> GetCities()
    {
        List<string> cities = new List<string>();

        while(true)
        {
            string input = Console.ReadLine();

            if(input == "X")
            {
                return cities;
            }

            if (!string.IsNullOrWhiteSpace(input))
            {
                cities.Add(input);
            }
        }
    }

    public void RunApp()
    {
        Console.WriteLine("Enter cities: ");

        var cities = GetCities();

        var dictionary = cities
            .OrderBy(a => a)
            .GroupBy(b => b[0])
            .ToDictionary(c => c.Key, c => c.ToList());

        Console.WriteLine("Enter letters:");

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "KONIEC")
                break;

            char letter = char.Parse(input);

            if (dictionary.ContainsKey(letter))
            {
                foreach (var city in dictionary[letter])
                {
                    Console.Write($"{city} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("PUSTE");
            }
        }
    }
}