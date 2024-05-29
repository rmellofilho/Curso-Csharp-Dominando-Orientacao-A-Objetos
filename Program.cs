using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Smartphone iphone = new("Iphone 8", 2000.00, "IOS");
        Console.WriteLine(iphone.ExibirInformacoes());
    }
}