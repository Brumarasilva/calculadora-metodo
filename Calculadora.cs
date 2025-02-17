using System.Runtime.InteropServices;
using Layout;

namespace Calculadora
{
    class Operacoes
    {

        public static decimal ObterValor()
        {
            Formatacao.Cor("Entre com o valor:", ConsoleColor.Yellow);
        repetir:
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.WriteLine("Valor Inválido");
                goto repetir;
            }
                return valor;
        }
        public static void RealizarAdicao()
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

           Formatacao.Cor($"{valor1} + {valor2} = {valor1 + valor2} ", ConsoleColor.Green);

        }
        public static void RealizarSubtracao()
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

           Formatacao.Cor($"{valor1} - {valor2} = {valor1 - valor2}", ConsoleColor.Green);
        }

        public static void RealizarMultiplicacao()
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

            Formatacao.Cor($"{valor1} * {valor2} = {valor1 * valor2}", ConsoleColor.Green);
        }

        public static void Realizardivisao()
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

            Formatacao.Cor($"{valor1} / {valor2} = {valor1 / valor2}", ConsoleColor.Green);
        }
        public static void sair()
        {
           Formatacao.Cor("Você saiu!....", ConsoleColor.Red);
        }
    }
}
