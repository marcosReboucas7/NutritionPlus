using System.Globalization;

namespace NutritionPlus.Entities
{
    internal class Imc
    {

        public double Peso { get; set; }
        public double Altura { get; set; }

        public Imc(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }


        public string CalcularImc(double peso, double altura)
        {
            double imc = peso / (altura * altura);

            string mensagemPeso;

            if(imc <= 18.5)
            {
                mensagemPeso = $"Seu IMC é: {imc.ToString("F2", CultureInfo.InvariantCulture)}. Você está Abaixo do peso.";
            }
            else if(imc > 18.5 && imc <= 24.9)
            {
                mensagemPeso = $"Seu IMC é: {imc.ToString("F2", CultureInfo.InvariantCulture)}. Você está com Peso normal.";
            }
            else if(imc >= 25 && imc <= 29.9)
            {
                mensagemPeso = $"Seu IMC é: {imc.ToString("F2", CultureInfo.InvariantCulture)}. Você está com Sobrepeso.";
            }
            else if(imc >= 30 && imc <= 34.9)
            {
                mensagemPeso = $"Seu IMC é: {imc.ToString("F2", CultureInfo.InvariantCulture)}. Você está com Obesidade grau 1.";
            }
            else if(imc >= 35 && imc <= 39.9)
            {
                mensagemPeso = $"Seu IMC é: {imc.ToString("F2", CultureInfo.InvariantCulture)}. Você está com Obesidade grau 2.";
            }
            else
            {
                mensagemPeso = $"Seu IMC é: {imc.ToString("F2", CultureInfo.InvariantCulture)}. Você está com Obesidade grau 3.";
            }


            return mensagemPeso;
        }
    }
}
