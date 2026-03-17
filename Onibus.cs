class Onibus : Veiculo, ISeguravel
{
    public int NumeroEixos { get; set; }

    public Onibus(string renavam, string modelo, int kmTotal, double valorDiaria, int eixos)
        : base(renavam, modelo, kmTotal, valorDiaria)
    {
        this.NumeroEixos = eixos;
    }

    public double CalcularSeguro()
    {
        return 50.0 + (10.0 * NumeroEixos);
    }
}