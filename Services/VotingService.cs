class VotingService
{
    private List<Election> currentElections;

    public VotingService()
    {
        currentElections = new List<Election>();
    }

    public Election AddNewElection()
    {
        var hardcodedOptions = new List<ElectionOption>
        {
            new ElectionOption("Høyre"),
            new ElectionOption("Arbeiderpartiet"),
        };

        Election newElection = new Election(hardcodedOptions);

        currentElections.Add(newElection);

        return newElection;
    }
}