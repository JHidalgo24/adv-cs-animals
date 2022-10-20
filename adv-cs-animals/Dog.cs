namespace AdvCSAnimals;

public class Dog : Pet, Talkable
{
    private bool _friendly;

    public bool Friendly
    {
        get => _friendly;
        set => _friendly = value;
    }

    public string getName()
    {
        return Name;
    }

    public string talk()
    {
        return "Bark";
    }

    public Dog(string name, bool friendly) : base(name)
    {
        this._friendly = friendly;
    }

    public override string ToString()
    {
        return $"Dog: name={Name} friendly={_friendly}";
    }
}