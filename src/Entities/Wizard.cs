namespace dungeonDIO.src.Entities;

public class Wizard : Hero
{
    public Wizard(string _name, int _level, string _heroType) : base(_name, _level, _heroType)
    {
        this.Name = _name;
        this.Level = _level;
        this.HeroType = _heroType;
    }

    public override string Attack()
    {
        return this.Name + " lançou uma magia";
    }

    public string Attack(int _bonus)
    {
        if (_bonus > 6) return this.Name + " lançou uma magia super efetiva com bônus de " + _bonus;
        else return this.Name + " lançou uma magia com força fraca com bônus de " + _bonus;
    }
}
