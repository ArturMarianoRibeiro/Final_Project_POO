class PessoaFisica : Cliente, ISeguravel
{
    public string Cpf { get; set; }
    public int Idade { get; set; }

    public PessoaFisica(string nome, string endereco, string cpf, int idade)
        : base(nome, endereco)
    {
        this.Cpf = cpf;
        this.Idade = idade;
    }

    public double CalcularSeguro()
    {
        return 20.0 + (0.5 * Idade);
    }
}