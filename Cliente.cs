abstract class Cliente
{
    private static int contagem = 0;
    public string Codigo { get;}
    public string Nome { get; set; }
    public string Endereco { get; set; }

    public Cliente(string nome, string endereco)
    {
        contagem++;
        this.Codigo = contagem.ToString();
        this.Nome = nome;
        this.Endereco = endereco;
    }
}