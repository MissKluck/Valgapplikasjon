class ElectionOption
{
    Guid id;
    public string name;
    public ElectionOption(string name)
    {
        this.name = name;
        id = Guid.NewGuid();
    }
}