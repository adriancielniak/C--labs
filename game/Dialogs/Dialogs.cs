class Dialogs
{
    public static NpcDialogPart Dialog1 = new NpcDialogPart("Hello, can you help me get to another town?",
    new[]
    {
           new HeroDialogPart("Yes, I'll gladly help", new
               NpcDialogPart("Thank you! As a reward, you will receive 100 gold coins from me.", new[]
                    {
                        new HeroDialogPart("I'll let you know when I'm ready", null),
                        new HeroDialogPart("100 gold coins are too little!" ,
                            new NpcDialogPart("Unfortunately, I don't have more. I'm very poor", new[]
                            {
                                new HeroDialogPart("In that case, fend for yourself", null),
                                new HeroDialogPart("Okay, 100 gold coins will do" ,
                                    new NpcDialogPart("Thank you", null))
                            })
                        )
                    })
               ),
           new HeroDialogPart("No, I won't help, goodbye", null)
    });

    public static NpcDialogPart Dialog2 = new NpcDialogPart("Hello #HERONAME#, welcome to the shop! What would you like to buy?",
    new[]
    {
        new HeroDialogPart("Sword (20 gold coins)", new NpcDialogPart("A sword is an excellent choice! The price is 20 gold coins.", new[]
        {
            new HeroDialogPart("That's too expensive; I'll try to haggle", new NpcDialogPart("I understand. I can offer it to you for 15 gold coins. What do you say, #HERONAME#?", new[]
            {
                new HeroDialogPart("Okay, agreed, I'll buy it for 15 gold coins", null),
                new HeroDialogPart("It's still too much, goodbye", null)
            })),
            new HeroDialogPart("Thank you, I'll buy it for 20 gold coins", null)
        })),
        new HeroDialogPart("Bow (30 gold coins)", new NpcDialogPart("A bow is an excellent choice! The price is 30 gold coins. What do you say, #HERONAME#?", new[]
        {
            new HeroDialogPart("That's too expensive; I'll try to haggle", new NpcDialogPart("I understand. I can offer it to you for 25 gold coins. What do you say, #HERONAME#?", new[]
            {
                new HeroDialogPart("Okay, agreed, I'll buy it for 25 gold coins", null),
                new HeroDialogPart("It's still too much, goodbye", null)
            })),
            new HeroDialogPart("Thank you, I'll buy it for 30 gold coins", null)
        })),
        new HeroDialogPart("Armor (40 gold coins)", new NpcDialogPart("Armor is an excellent choice! The price is 40 gold coins. What do you say?", new[]
        {
            new HeroDialogPart("That's too expensive; I'll try to haggle", new NpcDialogPart("I understand. I can offer it to you for 35 gold coins. What do you say, #HERONAME#?", new[]
            {
                new HeroDialogPart("Okay, agreed, I'll buy it for 35 gold coins", null),
                new HeroDialogPart("It's still too much, goodbye", null)
            })),
            new HeroDialogPart("Thank you, I'll buy it for 40 gold coins", null)
        })),
        new HeroDialogPart("Nothing, thank you", new NpcDialogPart("Thank you for visiting! If you change your mind, come back to me.", null)
        )
    });
}
