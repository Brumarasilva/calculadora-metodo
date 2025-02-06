namespace Calculadora
{
    class Operacoes
    {

        public static decimal ObterValor()
        {
            Console.WriteLine("informe o valor:");
            decimal valor = decimal.Parse(Console.ReadLine());
            return  valor;
        }
        public static void RealizarAdicao()
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

            Console.WriteLine($"A soma dos valores {valor1} e {valor2} é {valor1 + valor2} ");

        }
        public static void RealizarSubtracao()
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

            Console.WriteLine($"A subtração dos valores {valor1} e {valor2} é: {valor1 - valor2}");
        }

        public static void RealizarMultiplicacao()
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

            Console.WriteLine($"A Multiplicação dos valores {valor1} e {valor2} é: {valor1 * valor2}");
        }

        public static void Realizardivisao()
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

            Console.WriteLine($"A divisão dos valores {valor1} e {valor2} é: {valor1 / valor2}");
        }

        

    }



}
