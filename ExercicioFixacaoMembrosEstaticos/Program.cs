using System.Globalization;

namespace ExercicioFixacaoMembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotaçao do dolar? ");
            double precoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Qual o valor em dolar vai comprar? ");
            double valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorCompraCalculada = ConversorDeMoeda.Converter(precoDolar, valorCompra);

            Console.WriteLine($"Valor a ser pago em reais = {valorCompraCalculada.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
