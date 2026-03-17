class Locacao
{
    public string Codigo { get; }
    private static int contagem = 0;
    public Cliente Cliente { get; }
    public Veiculo Veiculo { get; }
    public DateTime DataHoraRetirada { get; }
    public int NumeroDiarias { get; }

    public Locacao(Cliente cliente, Veiculo veiculo, DateTime dataHoraRetirada, int numeroDiarias)
    {
        contagem++;
        Codigo = contagem.ToString();
        Cliente = cliente;
        Veiculo = veiculo;
        DataHoraRetirada = dataHoraRetirada;
        NumeroDiarias = numeroDiarias;
    }
    public double ValorTotalLocacao()
    {
        return (Veiculo.ValorDiaria+ ((ISeguravel)Cliente).CalcularSeguro() + ((ISeguravel)Veiculo).CalcularSeguro()) * NumeroDiarias;
    }
    public void EncerrarLocacao(int quilometragemRodada)
    {
        Veiculo.FinalizarLocacao(quilometragemRodada);
    }
}