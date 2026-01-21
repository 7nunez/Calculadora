using System.Runtime.CompilerServices;

Calc calculadora = new Calc();

Console.WriteLine("----------------------- / / -----------------------------");
Console.WriteLine("         CALCULADORA COM UM NÚMERO ALEATÓRIO");
Console.WriteLine("----------------------- / / -----------------------------");

int numeroAleatorio = calculadora.GerarNumeroAleatorio();
Console.WriteLine($"Numero aleatorio gerado: {numeroAleatorio}");

int opcao = 0;
do
{
    Console.WriteLine($"Número aleatório: {numeroAleatorio}");
    Console.WriteLine("1 - Soma.");
    Console.WriteLine("2 - Subtração.");
    Console.WriteLine("3 - Divisão.");
    Console.WriteLine("4 - Multiplicação.");
    Console.WriteLine("5 - Gerar novo número aleatório.");
    Console.WriteLine("6 - Sair.");
    Console.WriteLine("Escolha uma opção.");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------- / / -----------------------------");

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe um número que deseja somar:");
            int numeroSoma = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            calculadora.ExibirSoma(numeroAleatorio, numeroSoma);

            break;

        case 2:
            Console.WriteLine("A subtração será feita com o maior valor menos o menor valor.");
            Console.WriteLine("Informe um número que deseja subtrair:");
            int numeroSub = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            calculadora.ExibirSubtracao(numeroAleatorio, numeroSub);

            break;

        case 3:
            Console.WriteLine("A divisão será feita com o maior valor dividio pelo menor valor.");
            Console.WriteLine("Informe um número que deseja dividir:");
            double numeroDiv = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            calculadora.ExibirDivisao(numeroAleatorio, numeroDiv);

            break;

        case 4:
            Console.WriteLine("Informe um número que deseja multiplicar");
            int numeroMult = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            calculadora.ExibirMultiplicacao(numeroAleatorio, numeroMult);

            break;
        
        case 5:
            numeroAleatorio = calculadora.GerarNumeroAleatorio();
            Console.WriteLine($"Novo número aleatório gerado: {numeroAleatorio}");
            
            break;

        case 6:
            Console.WriteLine("Finalizando o programa...");

            break;
    }

    Console.WriteLine("----------------------- / / -----------------------------");

} while (opcao != 6);
