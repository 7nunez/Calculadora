public class Calc
{
    public void ExibirSoma(int n1, int n2)
    {
        int soma = n1+n2;
        Console.WriteLine($"A soma dos valores é: {soma}");
    }

    public int GerarNumeroAleatorio()
    {
        Random rnd = new Random();
        return rnd.Next(1,101);
    }

    public void ExibirSubtracao(int n1, int n2)
    {
        if(n1 > n2)
        {
            int subtracao = n1-n2;
        }
        else if (n2 > n1)
        {
            int subtracao = n2-n1;
        }
        else
        {
            int subtracao = n1-n2;
        }
        
        Console.WriteLine($"A subtração dos valores é: {subtracao}");
    }

}
