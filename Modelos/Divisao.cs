namespace Calculando;

public class Divisao
{
    public static double Dividir(double a, double b)
    {
        if (a != 0 || b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero.");
            return 0;
        }

    }
}