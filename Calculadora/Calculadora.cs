namespace Calculando;

public class Calculadora
{
    public static double Calcular(double a, double b, char operacao)
    {
        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = Soma.Somar(a, b);
                break;
            case '-':
                resultado = Subtracao.Subtrair(a, b);
                break;
            case '*':
                resultado = Multiplicacao.Multiplicar(a, b);
                break;
            case '/':
                resultado = Divisao.Dividir(a, b);
                break;
            case 'r':
                resultado = RaizQuadrada.CalcularRaizQuadrada(a);
                break;
            case 'p':
                resultado = Potencia.CalcularPotencia(a, b);
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
        return resultado;
    }
}