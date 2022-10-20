namespace AdvCSAnimals;

public class Teacher: Person, Talkable
{
    private int _age;
    public int Age { 
        get => _age;
        set => this._age = value;
    }
    public Teacher(string name, int age) : base(name)
    {
        this._age = age;
    }

    public string getName()
    {
        return Name;
    }

    public string talk()
    {
        return "Don't forget to do the assigned reading!";
    }
}