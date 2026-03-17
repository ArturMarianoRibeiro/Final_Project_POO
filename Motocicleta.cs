class Motocicleta : Veiculo, ISeguravel
{
    public int Cilindradas { get; set; }

    public Motocicleta(string renavam, string modelo, int kmTotal, double valorDiaria, int cilindradas)
        : base(renavam, modelo, kmTotal, valorDiaria)
    {
        this.Cilindradas = cilindradas;
    }

    public double CalcularSeguro()
    {
        return 40.0 + (0.1 * Cilindradas);
    }
}