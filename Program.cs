using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Calc calculadora = new Calc();

        int numeroAleatorio = calculadora.GerarNumeroAleatorio();
        Console.WriteLine($"Numero aleatorio gerado: {numeroAleatorio}");

        do
        {
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair.");
            Console.WriteLine("Escolha uma opção.");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe um número que deseja somar:");
                    int numeroSoma = int.Parse(Console.ReadLine());

                    calculadora.ExibirSoma(numeroAleatorio, numeroSoma);

                    break;
                
                case 2:
                    Console.WriteLine("Informe um número que deseja subtrair:");
                    int numeroSub = int.Parse(Console.WriteLine());

                    calculadora.ExibirSubtracao(numeroAleatorio, numeroSub);

                    break;
                
                case 3:
                    Console.WriteLine("Informe um número que deseja dividir:");
                    int numeroDiv = int.Parse(Console.ReadLine());

                    // fazer o metodo da divisão"
                    break;
                
                default:
            }


        } while (opcao != 5);








    }
}
