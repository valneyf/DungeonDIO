using dungeonDIO.src.Entities;
using static System.Console;

Knight arus = new Knight("Arus", 42);
WriteLine(arus);
WriteLine(arus.Attack());
WriteLine(arus.BattleSkill());

WriteLine();

Wizard jenica = new Wizard("Jenica", 12);

WriteLine(jenica);
WriteLine(jenica.Attack());
WriteLine(jenica.BattleSkill());

WriteLine();

Monk wedge = new Monk("Wedge", 31);
WriteLine(wedge);
WriteLine(wedge.Attack());
WriteLine(wedge.BattleSkill());

WriteLine();

WriteLine("########## Após uso de habilidades ##########");
WriteLine(arus);
WriteLine(jenica);
WriteLine(wedge);
