class RepositorioLocacoes
{
    private List<Locacao> locacoesCadastradas = [];
    public void AdicionarLocacao(Locacao locacao)
    {
        locacoesCadastradas.Add(locacao);

    }
    public List<Locacao> ObterTodas()
    {
        return locacoesCadastradas;
    }
}