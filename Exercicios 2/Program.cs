using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];
        int[] pares = new int[n];
        int countPares = 0; 

        Console.WriteLine("Digite os números:");
        for (int i = 0; i < n; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] % 2 == 0)
            {
                pares[countPares] = vetor[i]; 
                countPares++; 
            }
        }

       
        Console.Write("Números pares: ");
        for (int i = 0; i < countPares; i++)
        {
            Console.Write(pares[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Quantidade de pares: {countPares}");
    }
}
