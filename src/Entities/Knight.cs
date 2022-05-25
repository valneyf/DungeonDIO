namespace dungeonDIO.src.Entities;

public class Knight : Hero
{
    public Knight(string _name, int _level) : base(_name, _level)
    {
        this.HeroType = "Knight";
        this.Skill = "Head Break";
        this.MPSkill = 2;
    }

    public override string Attack()
    {
        return this.Name + " atacou com sua espada!";
    }
}
