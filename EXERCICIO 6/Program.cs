using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de pessoas: ");
        int n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        int[] idades = new int[n];

        Console.WriteLine("Digite o nome e a idade de cada pessoa:");
        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            nomes[i] = entrada[0];
            idades[i] = int.Parse(entrada[1]);
        }

        int indiceMaisVelho = 0;
        for (int i = 1; i < n; i++)
        {
            if (idades[i] > idades[indiceMaisVelho])
            {
                indiceMaisVelho = i;
            }
        }

        Console.WriteLine("Pessoa mais velha: "  + nomes[indiceMaisVelho] + "\n");
    }
}