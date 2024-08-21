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
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Meu Dicionário de carros:");

        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine();

        Queue<string> filaBanco = new Queue<string>();

        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");
        filaBanco.Enqueue("Luisa");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        Console.WriteLine();

        bool achou = filaBanco.Contains("Bia");
        if (achou == true)
        {
            Console.WriteLine("A pessoa está na fila.");
        }
        else
        {
            Console.WriteLine("A pessoa não está na fila.");
        }

        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine();

        Stack<string> livros = new Stack<string>();

        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de Neve e os sete anões");
        livros.Push("A Princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine();

    }
}