namespace AdvCSAnimals;

public abstract class Pet
{
    private string _name;
    
    public string Name { 
        get => _name;
        set => _name = value;
    }

    public Pet(string name)
    {
        this._name = name;
    }
    
}