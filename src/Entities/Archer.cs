namespace dungeonDIO.src.Entities;
public class Archer : Hero
{
    public Archer(string _name, int _level) : base(_name, _level)
    {
        this.HeroType = "Archer";
        this.Skill = "Charger";
        this.MPSkill = 3;
    }

    public override string Attack()
    {
        return this.Name + " atacou com seu arco!";
    }
}
