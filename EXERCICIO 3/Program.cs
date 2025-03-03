using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de elementos: ");
        int n = int.Parse(Console.ReadLine());

        int[] A = new int[n];
        int[] B = new int[n];
        int[] C = new int[n];

        Console.WriteLine("Digite os elementos do vetor A:");
        for (int i = 0; i < n; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os elementos do vetor B:");
        for (int i = 0; i < n; i++)
        {
            B[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            C[i] = A[i] + B[i];
        }

        Console.WriteLine("Vetor C (soma de A e B): " + string.Join(" ", C));
    }
}
