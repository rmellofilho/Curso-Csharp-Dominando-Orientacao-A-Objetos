namespace Desafio.Primeiro;
internal class Consulta{
    public Consulta(DateTime dataConsulta, Pet petParaConsulta, Medico medicoParaConsulta)
    {
        DataConsulta = dataConsulta;
        PetParaConsulta = petParaConsulta;
        MedicoParaConsulta = medicoParaConsulta;
    }

    public DateTime DataConsulta { get; }
    public Pet PetParaConsulta { get; }
    public Medico MedicoParaConsulta { get; }
}