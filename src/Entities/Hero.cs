using System.Text;

namespace dungeonDIO.src.Entities;

public abstract class Hero
{
    protected string Name { get; set; }
    protected int Level { get; set; }
    protected string HeroType { get; set; } = null!;
    protected int HealthPoints { get; set; }
    protected int TotalHealthPoints { get; set; }
    protected int MagicPoints { get; set; }
    protected int TotalMagicPoints { get; set; }
    protected string Skill { get; set; } = null!;
    protected int MPSkill { get; set; }

    public Hero(string _name, int _level)
    {
        this.Name = _name;
        this.Level = _level;
        this.TotalHealthPoints = HealthPoints = RandomStatus();
        this.TotalMagicPoints = MagicPoints = RandomStatus();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("##### Herói ##### ");
        sb.AppendLine($"Nome: {this.Name}");
        sb.AppendLine($"Nível: {this.Level}");
        sb.AppendLine($"Tipo de Herói: {this.HeroType}");
        sb.AppendLine($"Habilidade de Batalha: \"{this.Skill}\" / Custo: {this.MPSkill} MP");
        sb.AppendLine($"HP: {this.HealthPoints} / {this.TotalHealthPoints}");
        sb.AppendLine($"MP: {this.MagicPoints} / {this.TotalMagicPoints}");

        return sb.ToString();
    }

    private int RandomStatus()
    {
        Random aleatorio = new Random();

        return aleatorio.Next(10, 50);
    }

    public virtual string Attack()
    {
        return $"{this.Name} atacou com sua espada";
    }

    public string BattleSkill()
    {
        MagicPoints -= this.MPSkill;

        return $"{this.Name} utilizou sua habilidade \"{this.Skill}\" consumindo {this.MPSkill} de MP";
    }
}