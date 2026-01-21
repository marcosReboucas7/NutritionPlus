using System.Globalization;
using NutriMais;
using NutriMais.Entities;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TABELA IMC:");
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("IMC");
        Console.WriteLine();
        Console.WriteLine("Menos do que 18,5  -  Abaixo do peso");
        Console.WriteLine("Entre 18,5 e 24,9  -  Peso normal");
        Console.WriteLine("Entre 25 e 29,9    -  Sobrepeso");
        Console.WriteLine("Entre 30 e 34,9    -  Obesidade grau 1");
        Console.WriteLine("Entre 35 e 39,9    -  Obesidade grau 2");
        Console.WriteLine("Mais do que 40     -  Obesidade grau 3");

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("CALCULE SEU IMC:");
        Console.WriteLine();

        
        Console.Write("Peso: ");
        double peso = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.WriteLine();
        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        var imc = new Imc(peso, altura);
        var calculo = imc.CalcularImc(peso, altura);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(calculo);
    }
}

