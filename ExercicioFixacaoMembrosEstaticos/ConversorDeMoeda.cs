namespace ExercicioFixacaoMembrosEstaticos
{
    internal static class ConversorDeMoeda
    {
        public static double IOF = 6.0 / 100;

        public static double Converter(double precoDolar, double valorCompra)
        {
            var valorConvertido = precoDolar * valorCompra;
            return valorConvertido + (IOF * valorConvertido);
        }
    }
}
