using Calculadora;
using Menu;
using Layout;
return1:
Escolha.ExibirMenu();

string opcao = Console.ReadLine();
if (opcao == null)
{
    Console.WriteLine("valor vazio");
    Thread.Sleep(60000);
    Console.Clear();
}
switch (opcao)
{
    case "1":
        Operacoes.RealizarAdicao();
        break;
    case "2":
        Operacoes.RealizarSubtracao();
        break;
    case "3":
        Operacoes.RealizarMultiplicacao();
        break;
    case "4":
        Operacoes.Realizardivisao();
        break;
    case "0":
        Operacoes.sair();
        break;
    default:
        Thread.Sleep(60000);
        Console.Clear();
        goto return1;
}
Thread.Sleep(60000);
Console.Clear();
goto return1;











