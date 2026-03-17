class RepositorioVeiculo
{
    private List<Veiculo> veiculosCadastrados = [];

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculosCadastrados.Add(veiculo);

    }

    public Veiculo? BuscarPorCodigo(string renavam)
    {
        foreach (var veiculo in veiculosCadastrados)
        {
            if (veiculo.CodigoRenavam == renavam)
            { return veiculo; }
        }
        return null;
    }
    public List<Veiculo> ObterTodos()
    {
        return veiculosCadastrados;
    }
}