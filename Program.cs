using Calculadora;
using Menu;
using Layout;
bool opcaoValida = false;
Console.Clear();
while (true)
{
    Escolha.ExibirMenu();

    do
    {
        string opcao = Console.ReadLine();
       
        switch (opcao)
        {
            case "1":
            opcaoValida = true;
                Operacoes.RealizarAdicao();
                break;
            case "2":
             opcaoValida = true;
                Operacoes.RealizarSubtracao();
                break;
            case "3":
             opcaoValida = true;
                Operacoes.RealizarMultiplicacao();
                break;
            case "4":
             opcaoValida = true;
                Operacoes.Realizardivisao();
                break;
            case "0":
               opcaoValida = true;
                Operacoes.sair();
                return;
            default:
                opcaoValida = false;
                Console.WriteLine("opção Inválida: Tente Novamente! ");
                break;




        }
    } while (opcaoValida == false);
}













