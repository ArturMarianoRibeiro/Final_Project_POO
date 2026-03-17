class Automovel : Veiculo, ISeguravel
{
    public int CapacidadePortaMalas { get; set; }

    public Automovel(string renavam, string modelo, int kmTotal, double valorDiaria, int portaMalas)
        : base(renavam, modelo, kmTotal, valorDiaria)
    {
        this.CapacidadePortaMalas = portaMalas;
    }

    public double CalcularSeguro()
    {
        return 20.0 + (0.01 * QuilometragemTotal);
    }
}