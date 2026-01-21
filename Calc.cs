public class Calc
{
    public int GerarNumeroAleatorio()
    {
        Random rnd = new Random();
        return rnd.Next(1, 101);
    }

/*   public int LerInt(string n1)
    {
        while (true)
        {
            Console.Write(n1);
            string? entrada = Console.ReadLine();
            int valor = 0;

            if (int.TryParse(entrada, out valor))
            {
                return valor;
            }
            Console.WriteLine("Valor inserido invalido!. Tente novamente inserido um número.");
        }

    }
*/
    public void ExibirSoma(int n1, int n2)
    {
        int soma = n1 + n2;
        Console.WriteLine($"A soma dos valores é: {soma}");
    }

    public void ExibirSubtracao(int n1, int n2)
    {
        int subtracao = 0;

        if (n1 > n2)
        {
            subtracao = n1 - n2;
        }
        else if (n2 > n1)
        {
            subtracao = n2 - n1;
        }
        else
        {
            subtracao = n1 - n2;
        }

        Console.WriteLine($"A subtração dos valores é: {subtracao}");
    }

    public void ExibirDivisao(double n1, double n2)
    {
        double divisao = 0;

        if (n1 > n2)
        {
            divisao = n1 / n2;
        }
        else if (n2 > n1)
        {
            divisao = n2 / n1;
        }
        else
        {
            divisao = n1 / n2;
        }

        Console.WriteLine($"O quociente da divisão dos valores é: {divisao:F2}");
    }

    public void ExibirMultiplicacao(int n1, int n2)
    {
        int multiplicacao = n1 * n2;

        Console.WriteLine($"O produto da multiplicação dos valores é: {multiplicacao}");
    }

}
