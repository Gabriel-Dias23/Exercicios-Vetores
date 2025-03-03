using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
        
    {
        CultureInfo CI = CultureInfo.InvariantCulture;


        Console.Write("Digite a quantidade de números: ");
        int n = int.Parse(Console.ReadLine());

        double[] vetor = new double[n];
        double soma = 0.0;

        Console.WriteLine("Digite os números:");
        for (int i = 0; i < n; i++)
        {
            vetor[i] = double.Parse(Console.ReadLine());
            soma += vetor[i];
        }

        double media = soma / n;
        List<double> abaixoDaMedia = new List<double>();

        foreach (double num in vetor)
        {
            if (num < media)
            {
                abaixoDaMedia.Add(num);
            }
        }

        Console.WriteLine($"Média: {media.ToString("F3",CI)}");
        Console.WriteLine("Números abaixo da média: " + string.Join(" ", abaixoDaMedia));
    }
}
