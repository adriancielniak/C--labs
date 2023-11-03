
using System;

public class Voter
{
    private bool CanVote;

    public event EventHandler<MyEventArgs>? Voted;

    public Voter(Parlament parlament)
    {
        CanVote = false;
        Voted += parlament.GetVote;
    }

    public void Vote()
    {
        if (CanVote)
        {
            Random random = new Random();
            bool temp = random.Next(2) == 0;
            OnVoted(new MyEventArgs(temp));
            CanVote = false;
        }
        else
        {
            Console.WriteLine("This member can'n vote");
        }
    }

    public void CanVoteTrue(object sender, EventArgs e)
    {
        CanVote = true;
    }

    internal void CanVoteFalse(object sender, EventArgs e)
    {
        CanVote = false;
    }

    protected virtual void OnVoted(MyEventArgs e)
    {
        Voted?.Invoke(this, e);
    }
}

public class MyEventArgs: EventArgs
{
    public bool Vote;

    public MyEventArgs(bool vote)
    {
        Vote = vote;
    }
}