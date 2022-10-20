namespace AdvCSAnimals;

public abstract class Person
{
    private string _name;

    public string Name
    {
        get => _name;
        set => this._name = value;
    }

    protected Person(string name) {
        this._name = name;
    }

    

}