namespace dungeonDIO.src.Entities;

public class Knight : Hero
{
    public Knight(string _name, int _level, string _heroType) : base(_name, _level, _heroType)
    {
        this.Name = _name;
        this.Level = _level;
        this.HeroType = _heroType;
    }

    public override string Attack()
    {
        return this.Name + " atacou com sua espada";
    }

    public string Attack(int _bonus)
    {
        return this.Name + " atacou com sua espada com bônus de " + _bonus;
    }
}
