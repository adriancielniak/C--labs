
public class Parlament
{
    public Voter [] Voters;
    public List<bool> VoteList;
    public string Topic;

    public event EventHandler StartVotingEvent;
    public event EventHandler EndVotingEvent;

    public Parlament(int _MembersAmount, string _Topic)
    {
        Topic = _Topic;
        VoteList = new List<bool>();
        Voters = new Voter[_MembersAmount];

        for(int i = 0; i < _MembersAmount; i++)
        {
            Voters[i] = new Voter(this);

            StartVotingEvent += Voters[i].CanVoteTrue;
            EndVotingEvent += Voters[i].CanVoteFalse;
        }
    }

    protected virtual void OnStartVotingEvent(EventArgs e)
    {
        StartVotingEvent?.Invoke(this, e);
    }

    protected virtual void OnEndVotingEvent(EventArgs e)
    {
        EndVotingEvent?.Invoke(this, e);
    }

    public void StartVoting(string topic)
    {
        Console.WriteLine("Voting has started for the topic: " + topic);
        OnStartVotingEvent(EventArgs.Empty);
    }

    public void StopVoting()
    {
        OnEndVotingEvent(EventArgs.Empty);

        int yes = 0;
        int no = 0;
        for(int i = 0; i < VoteList.Count; i++)
        {
            if (VoteList[i])
            {
                yes++;
            }
            else
            {
                no++;
            }
        }

        Console.WriteLine("Voting has ended.");
        Console.WriteLine("Voting Results for Topic: " + Topic);
        Console.WriteLine("Yes Votes: " + yes);
        Console.WriteLine("No Votes: " + no);
    }

    internal void GetVote(object sender, MyEventArgs e)
    {

        VoteList.Add(e.Vote);
    }
}