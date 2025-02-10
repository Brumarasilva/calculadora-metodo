namespace Layout
{
    class Formatacao
    {
        public static void cor (string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
