using System;

class Location
{
    public string locationName;
    public List<NonPlayerCharacter> npcs;

    public Location(string _locationName)
    {
        locationName = _locationName;
        npcs = new List<NonPlayerCharacter>();
    }

    public void AddNpc(NonPlayerCharacter npc)
    {
        npcs.Add(npc);
    }   
}