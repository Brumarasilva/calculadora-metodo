using System.Runtime.InteropServices;
using Layout;

namespace Calculadora
{
    class Operacoes//Quando o usuário digitar o número dentro do  programa. O programa vai imprimir um menu na tela e o usuário vai escolher uma das opções abaixo dando ao usuário a possibilidade de somar, subtrair, dividir e multiplicar o número.
    {

        public static decimal ObterValor()//
        {
            Formatacao.Cor("Entre com o valor:", ConsoleColor.Yellow);//Exibe a mensagem no programa com a cor da letra modificada para amarelo.
        repetir:
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))//caso o número que o usuário digitou for dado como "valor inválido" pelo programa, o programa vai retornar e (goto_repetir) o processo até o usuário digitar um valor válido.
            {
                Console.WriteLine("Valor Inválido");
                goto repetir;
            }
                return valor;
        }
        public static void RealizarAdicao()//Esta função está somando os valores
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

           Formatacao.Cor($"{valor1} + {valor2} = {valor1 + valor2} ", ConsoleColor.Green);//Aqui o programa vai pegar os dois valores fornecidos pelo usuário e vai somar e o resultado vai aparecer em cor verde.

        }
        public static void RealizarSubtracao()//Esta função esta subtraindo os valores
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

           Formatacao.Cor($"{valor1} - {valor2} = {valor1 - valor2}", ConsoleColor.Green);//Aqui o programa vai pegar os dois valores fornecidos pelo usuário e vai subtrair, e o resultado vai aparecer em cor verde.
        }

        public static void RealizarMultiplicacao()//Esta função esta multplicando os valores
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

            Formatacao.Cor($"{valor1} * {valor2} = {valor1 * valor2}", ConsoleColor.Green);//Aqui o programa vai pegar os dois valores fornecidos pelo usuário e vai multiplicar. e o resultado vai aparecer em cor verde.
        }

        public static void Realizardivisao()//Esta função esta dividindo os valores
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();

            Formatacao.Cor($"{valor1} / {valor2} = {valor1 / valor2}", ConsoleColor.Green);//Aqui o programa vai pegar os dois valores fornecidos pelo usuário e vai dividir, e o resultado vai aparecer em cor verde.
        }
        public static void sair()// Após o usuário obter o resultado que estava procurando se ele quiser sair vai precisar digitar a opção é o programa vai ser encerrado.
        {
           Formatacao.Cor("Você saiu!....", ConsoleColor.Red);//Quando o usuário sair a imagem vai ser impressa em vermelho.
        }
    }
}
