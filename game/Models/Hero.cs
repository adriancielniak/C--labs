using System;

public class Hero
{
    public string Name { get; set; }
    public EHeroClass HeroClass { get; set; }

    public Hero(string _Name, EHeroClass _heroClass)
    {
        this.Name = _Name;
        this.HeroClass = _heroClass;
    }
}