using Calculadora;

using Menu;


return1:
Escolha.ExibirMenu();

string opcao = Console.ReadLine();

switch (opcao)

{
    case "+":

        Operacoes.RealizarAdicao();
         goto return1;


    case "-":
        Operacoes.RealizarSubtracao();
         goto return1;


    case "*":
        Operacoes.RealizarMultiplicacao();
        goto return1;



    case "/":
        Operacoes.Realizardivisao();
         goto return1;

      
       
}












