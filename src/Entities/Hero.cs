using System.Text;

namespace dungeonDIO.src.Entities;

public abstract class Hero
{
    public string Name;
    public int Level;
    public string HeroType;

    public Hero(string _name, int _level, string _heroType)
    {
        this.Name = _name;
        this.Level = _level;
        this.HeroType = _heroType;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Herói: ");
        sb.AppendLine("Nome: " + this.Name);
        sb.AppendLine("Nível: " + this.Level);
        sb.AppendLine("Tipo de Herói: " + this.HeroType);

        return sb.ToString();
    }

    public virtual string Attack()
    {
        return this.Name + " atacou com sua espada";
    }
}