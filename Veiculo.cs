abstract class Veiculo
{
    public string CodigoRenavam { get; set; }
    public string Modelo { get; set; }
    public int QuilometragemTotal { get; set; }
    public double ValorDiaria { get; set; }
    public bool Locado { get; set; }

    public Veiculo(string renavam, string modelo, int kmTotal, double valorDiaria)
    {
        this.CodigoRenavam = renavam;
        this.Modelo = modelo;
        this.QuilometragemTotal = kmTotal;
        this.ValorDiaria = valorDiaria;
        this.Locado = false;
    }

    public void IniciarLocacao()
    {
        Locado = true;
    }

    public void FinalizarLocacao(int quilometragemRodada)
    {
        QuilometragemTotal += quilometragemRodada;
        Locado = false;
    }
}