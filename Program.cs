using System;
using dungeonDIO.src.Entities;
using dungeonDIO.src.Enums;
using static System.Console;

ConsoleKeyInfo cki;

Hero hero;

do
{
    Clear();
    WriteLine("=========== Dungeon DIO ===========");
    WriteLine();
    Write("Deseja criar um novo personagem? (S/N) ");
    cki = ReadKey();

    switch (cki.Key)
    {
        case ConsoleKey.S:
            CreateHero();
            break;
        case ConsoleKey.N:
            WriteLine("\nSaindo da Dungeon DIO... Até a próxima aventura!");

            Environment.Exit(0);
            break;
        default:
            WriteLine("Opção inválida! Favor utilizar S para 'SIM' e N para 'NÃO'");
            break;
    }
} while (cki.Key != ConsoleKey.N);

void CreateHero()
{
    WriteLine();

    // Criar Hero (Archer, Knight, Monk, Wizard)
    Write("Informe o nome: ");
    string? inputName = ReadLine();
    if (string.IsNullOrEmpty(inputName) || string.IsNullOrWhiteSpace(inputName))
    {
        WriteLine("Nome do personagem não pode ser vazio");
        WriteLine("\nRetornando para a tela inicial...");
        Thread.Sleep(3000);
        return;
    }

    Write("Informe o nível: ");
    int inputLevel = int.TryParse(ReadLine(), out int input) ? input : 0;
    if (inputLevel <= 0)
    {
        WriteLine("Nível do personagem precisa ser maior que zero");
        WriteLine("\nRetornando para a tela inicial...");
        Thread.Sleep(3000);
        return;
    }

    WriteLine("Informe a classe pela numeração: ");
    foreach (var job in Enum.GetValues<HeroType>())
    {
        WriteLine($">>> {(int)job} - {job} ");
    }
    int inputHeroType = int.Parse(ReadLine());

    if (!Enum.IsDefined(typeof(HeroType), inputHeroType))
    {
        WriteLine("Favor utilizar valor de uma das opções listadas");
        WriteLine("\nRetornando para a tela inicial...");
        Thread.Sleep(3000);
        return;
    }
    else
    {
        WriteLine();

        switch (inputHeroType)
        {
            case 1:
                hero = new Archer(inputName, inputLevel);
                break;
            case 2:
                hero = new Knight(inputName, inputLevel);
                break;
            case 3:
                hero = new Monk(inputName, inputLevel);
                break;
            case 4:
                hero = new Wizard(inputName, inputLevel);
                break;
            default:
                hero = null;
                break;
        }

        WriteLine(hero);
        WriteLine(hero.Attack());
        WriteLine(hero.BattleSkill());
        WriteLine("\n##################################\n");
        WriteLine(hero);

        WriteLine($"\n{hero.GetName()} está retornando para o vilarejo...");
        cki = ReadKey(false);
    }
}