using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Minha primeira branch");
        //Console.WriteLine("Trabalhando com Git\\Github");
        //Console.WriteLine("Mais uma tentativa de trabalhar com Git");

        List<string> frutas = new List<string>();

        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);

        }

        Console.WriteLine("Fruta na indice 2: " + frutas[2]);

        frutas.Insert(1, "Maracujá");

        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);

        }

        frutas[4] = "Pera";

        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);

        }

        frutas.RemoveAt(3);
        frutas.Remove("Morango");

        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);

        }

        frutas.Clear();

        Dictionary<int, string> carros = new Dictionary<int, string>();

        carros.Add(5, "Corsa");
        carros.Add(18, "Fusca");
        carros.Add(2, "Ferrari");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Meu Dicionário de carros:");

        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

    }
}