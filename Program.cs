using dungeonDIO.src.Entities;
using static System.Console;

Knight arus = new Knight("Arus", 42, "Knight");
Wizard jenica = new Wizard("Jenica", 43, "White Wizard");

WriteLine(arus.Attack());

WriteLine();

WriteLine(jenica.Attack(4));
WriteLine(jenica.Attack(7));