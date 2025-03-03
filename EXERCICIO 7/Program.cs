using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de alunos: ");
        int n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        double[] notas1 = new double[n];
        double[] notas2 = new double[n];

        Console.WriteLine("Digite o nome e as duas notas de cada aluno:");
        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            nomes[i] = entrada[0];
            notas1[i] = double.Parse(entrada[1]);
            notas2[i] = double.Parse(entrada[2]);
        }

        Console.WriteLine("Alunos aprovados:");
        for (int i = 0; i < n; i++)
        {
            double media = (notas1[i] + notas2[i]) / 2;
            if (media >= 6.0)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
