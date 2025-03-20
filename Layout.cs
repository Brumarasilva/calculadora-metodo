namespace Layout
{
    class Formatacao
    {
        public static void Cor (string mensagem, ConsoleColor cor)//este é um código para formatação de cor.
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}
