namespace dungeonDIO.src.Entities;

public class Monk : Hero
{
    public Monk(string _name, int _level) : base(_name, _level)
    {
        this.HeroType = "Monk";
        this.Skill = "Spin Fist";
        this.MPSkill = 3;
    }

    public override string Attack()
    {
        return this.Name + " atacou com seu punho!";
    }
}
