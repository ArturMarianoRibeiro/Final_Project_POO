class RepositorioClientes
{
    private List<Cliente> clientesCadastrados = [];

    public void AdicionarCliente(Cliente cliente)
    {
        clientesCadastrados.Add (cliente);

    }

    public Cliente? BuscarPorCodigo(string codigo)
    { 
        foreach(var cliente in clientesCadastrados)
        {
            if (cliente.Codigo == codigo)
            { return cliente; }
        }
        return null; 
    }
    public List<Cliente> ObterTodos()
    {
        return clientesCadastrados;
    }
}