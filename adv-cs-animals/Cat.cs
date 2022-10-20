namespace AdvCSAnimals;

public class Cat: Pet, Talkable
{
    private int _miceKilled;
    
    public int MiceKilled { 
        get => _miceKilled;
        set => _miceKilled = value;
    }


    public Cat(string name, int miceKilled) : base(name)
    {
        this._miceKilled = miceKilled;
    }
    
    public void addMouse() {
        _miceKilled++;
    }

    public string getName()
    {
        return Name;
    }

    public string talk()
    {
        return "Meow";
    }

    public override string ToString()
    {
        return $"Cat: name={Name} mousesKilled={_miceKilled}";
    }
}