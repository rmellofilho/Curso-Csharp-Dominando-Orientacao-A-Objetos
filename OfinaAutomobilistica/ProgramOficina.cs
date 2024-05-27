using OficinaAutomobilistica;

class ProgramOficina
{
    static void Main(string[] args)
    {

        Cliente cliente1 = new("Roberto Melo");

        Veiculo veiculo1 = new("Volkswagen", "T-Cross TSI ", 2023, "PLACA1", cliente1);

        cliente1.AdicionarVeiculo(veiculo1);

        System.Console.WriteLine();
        cliente1.ExibirVeiculos();

        Mecanico mecanico1 = new Mecanico("Mecânico 1");

        OrdemDeServico ordemDeServico1 = new(veiculo1, mecanico1, "Troca de Óleo", "2024-05-25");
        OrdemDeServico ordemDeServico2 = new(veiculo1, mecanico1, "Revisão geral", "2024-06-04");

        System.Console.WriteLine();
        ordemDeServico1.ExibirOrdemDeServico();

        System.Console.WriteLine();
        veiculo1.ExibirServicosExecutados();
    }
}