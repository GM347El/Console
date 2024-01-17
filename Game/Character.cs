namespace Game;

public class Character
{
    public string Name { get; set; }
    public virtual int Life { get; set; }

    public Character(string name, int life, int vertical, int horizontal)
    {
        Name = name;
        Life = life;
        VPosition = vertical;
        HPosition = horizontal;
    }

    public int VPosition { get; set; }
    public int HPosition { get; set; }
}

