using System.Globalization;
using NutritionPlus;
using NutritionPlus.Entities;
using NutritionPlus.Views;

static class Program
{
    static void Main(string[] args)
    {
        string view = new Table().TabelaImc();
        Console.WriteLine(view);

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

