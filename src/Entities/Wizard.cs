namespace dungeonDIO.src.Entities;

public class Wizard : Hero
{
    public Wizard(string _name, int _level) : base(_name, _level)
    {
        this.HeroType = "Wizard";
        this.Skill = "Poison";
        this.MPSkill = 4;
    }

    public override string Attack()
    {
        return this.Name + " lançou uma magia!";
    }
}
