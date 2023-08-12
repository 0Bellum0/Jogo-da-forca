// See https://aka.ms/new-console-template for more information

using JogoDaForca;

World world = new World(10, 20);

string forca = @"
_______
|     ¿
|
|
-
";

string palavra = "palavra";

string descoberto = "_______";

string erros = "";

world.Fill();
world.Add(2, 4, forca);
world.Draw();


while (true)
{
    world.Fill();
    Console.WriteLine("Digite uma Letra: ");
    string letra = Console.ReadLine();

    if (letra == "0")
    {
        break;
    }

    if (palavra.Contains(letra))
    {

    }
    else
    {
        erros += $"{letra}";
    }
}

world.Add(2, 4, descoberto);
world.Add(7, 4, erros);
world.Draw();