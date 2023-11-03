using System;

class Person
{
    public string Name { get; set; }
    public string SecondName { get; set; }

    public Person(string name, string secondName)
    {
        Name = name;
        SecondName = secondName;
    }
}