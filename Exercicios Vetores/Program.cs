using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números: ");
        int N = int.Parse(Console.ReadLine());

        double[] vetor = new double[N];
        Console.WriteLine("Digite os números:");
        for (int i = 0; i < N; i++)
        {
            vetor[i] = double.Parse(Console.ReadLine());
        }

        double maior = vetor[0];
        int posicao = 0;

        for (int i = 1; i < N; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
                posicao = i;
            }
        }

        Console.Write("Maior número: "+ maior + "\n");
        Console.Write("Posição:  " + posicao + "\n");
        Console.ReadLine();    
    }
}
