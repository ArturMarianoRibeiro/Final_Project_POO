class Empresa : Cliente, ISeguravel
{
    public string Cnpj { get; set; }

    public Empresa(string nome, string endereco, string cnpj)
        : base(nome, endereco)
    {
        this.Cnpj = cnpj;
    }

    public double CalcularSeguro()
    {
        return 30.0;
    }
}