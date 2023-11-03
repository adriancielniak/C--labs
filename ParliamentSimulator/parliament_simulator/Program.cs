
class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Enter number of members: ");

        int membersAmount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the voting topic: ");

        string topic = Console.ReadLine();

        Parlament parlament = new Parlament(membersAmount, topic);

        while (true)
        {
            string cmd = Console.ReadLine();
            string[] cmdParts = cmd.Split(" ");


            switch(cmdParts[0])
            {
                case "POCZĄTEK":
                    parlament.StartVoting(cmdParts[1]);
                    break;
                case "KONIEC":
                    parlament.StopVoting();
                    break;
                case "GŁOS":
                    parlament.Voters[Convert.ToInt32(cmdParts[1])].Vote();
                    break;
                default:
                    return;
            }
        }
        
    }
}