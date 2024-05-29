class Eletronico
{
    protected string Modelo { get; set; }
    protected double Preco { get; set; }

    public Eletronico(string modelo, double preco)
    {
        Modelo = modelo;
        Preco = preco;
    }

    public virtual string ExibirInformacoes()
    {
        return $"Modelo: {this.Modelo} | Preço: {this.Preco} ";
    }
}