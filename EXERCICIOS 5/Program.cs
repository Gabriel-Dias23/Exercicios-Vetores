using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];
        int soma = 0, qtdPares = 0;

        Console.WriteLine("Digite os números:");
        for (int i = 0; i < n; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] % 2 == 0)
            {
                soma += vetor[i];
                qtdPares++;
            }
        }

        if (qtdPares > 0)
        {
            double media = (double)soma / qtdPares;
            Console.WriteLine($"Média dos números pares: {media:F1}");
        }
        else
        {
            Console.WriteLine("Nenhum número par encontrado.");
        }
    }
}
