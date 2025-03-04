using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()); 
        int lucroAbaixo10 = 0, lucroEntre10e20 = 0, lucroAcima20 = 0;
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

        for (int i = 0; i < N; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            string nome = entrada[0];
            double precoCompra = double.Parse(entrada[1].Replace(',', '.'));
            double precoVenda = double.Parse(entrada[2].Replace(',', '.'));

            
            double lucro = ((precoVenda - precoCompra) / precoCompra) * 100;

            
            if (lucro < 10) lucroAbaixo10++;
            else if (lucro <= 20) lucroEntre10e20++;
            else lucroAcima20++;

           
            totalCompra += precoCompra;
            totalVenda += precoVenda;
            lucroTotal += (precoVenda - precoCompra);
        }

        Console.WriteLine("Lucro abaixo de 10%: " + lucroAbaixo10);
        Console.WriteLine("Lucro entre 10% e 20%: " + lucroEntre10e20);
        Console.WriteLine("Lucro acima de 20%: " + lucroAcima20);
        Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2"));
        Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2"));
        Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2"));
    }
}
