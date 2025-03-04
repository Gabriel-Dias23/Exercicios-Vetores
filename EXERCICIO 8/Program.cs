using System;

    class program
    {
        static void Main()
        {
                    

        int NUM = int.Parse(Console.ReadLine());
        double menorAltura = double.MaxValue, maiorAltura = double.MinValue;
        double somaAlturaMulheres = 0;
        int qtdsMulheres = 0, qtdsHomens = 0;

        for (int i = 0; i < NUM; i++)

        {
            string[] entrada = Console.ReadLine().Split(' ');
            double altura = double.Parse(entrada[0].Replace(',', '.'));
            char sexo = char.Parse(entrada[1]);

            if (altura < menorAltura) menorAltura = altura;
            if (altura > maiorAltura) maiorAltura = altura;

            if(sexo == 'F')
            {
                somaAlturaMulheres += altura;
                qtdsMulheres++;
            }
            else if (sexo == 'M')
            {
                qtdsHomens++;
            }



        }

        double mediaAlturaMulheres = (qtdsMulheres > 0) ? somaAlturaMulheres / qtdsMulheres : 0.0;

        Console.WriteLine("Menor altura =" + menorAltura.ToString("F2"));
        Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2"));
        Console.WriteLine("Media das alturas das mulheres = " + mediaAlturaMulheres.ToString("F2"));
        Console.WriteLine("Numero de homens = " + qtdsHomens);






    }

}