using System.Text;

namespace NutritionPlus.Views
{
    public class Table
    {
        public string TabelaImc()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TABELA IMC:");
            sb.AppendLine();
            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine();
            sb.AppendLine("IMC");
            sb.AppendLine();
            sb.AppendLine("Menos do que 18,5  -  Abaixo do peso");
            sb.AppendLine("Entre 18,5 e 24,9  -  Peso normal");
            sb.AppendLine("Entre 25 e 29,9    -  Sobrepeso");
            sb.AppendLine("Entre 30 e 34,9    -  Obesidade grau 1");
            sb.AppendLine("Entre 35 e 39,9    -  Obesidade grau 2");
            sb.AppendLine("Mais do que 40     -  Obesidade grau 3");
            sb.AppendLine();
            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("CALCULE SEU IMC:");
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
