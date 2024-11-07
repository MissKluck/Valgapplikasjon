class Election
{
    public Guid id; // { get; init; }; get = hente, set = lese av, init = lese av privat
    public List<ElectionOption> options;
    public List<Vote> castVotes;

    public Election(List<ElectionOption> electionOptions)
    {
        if (electionOptions.Count <= 1)
        {
            throw new ArgumentException("An election needs at least two options");
        }

        options = new List<ElectionOption>();
        castVotes = new List<Vote>();
        id = Guid.NewGuid();
    }
}