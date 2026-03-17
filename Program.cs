var repoClientes = new RepositorioClientes();
var repoVeiculos = new RepositorioVeiculo();
var repoLocacoes = new RepositorioLocacoes();

while (true)
{
    Console.WriteLine("Escolha uma opção:\n" +
        "1 – Cadastrar Cliente\n" +
        "2 – Cadastrar Veículo\n" +
        "3 – Iniciar Locação\n" +
        "4 – Finalizar Locações\n" +
        "5 – Listar Clientes\n" +
        "6 – Listar Veículos\n" +
        "7 – Listar Locações\n" +
        "8 – Sair\n");

    int opcao = int.Parse((Console.ReadLine() ?? ""));

    switch (opcao)
    {
        case 1:
            {
                Console.WriteLine("Escolha uma opção: \n" +
                    "1 - Pessoa Física\n" +
                    "2 - Empresa");
                int opcao_cliente = int.Parse((Console.ReadLine() ?? ""));
                if (opcao_cliente == 1 )
                {
                    Console.WriteLine("Digite o nome:");
                    string nome = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o endereço:");
                    string endereco = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o CPF:");
                    string cpf = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite a idade:");
                    int idade = int.Parse(Console.ReadLine() ?? "");

                    var PessoaFisica1 = new PessoaFisica(nome, endereco, cpf, idade);
                    repoClientes.AdicionarCliente(PessoaFisica1);
                }
                else if (opcao_cliente == 2 )
                {
                    Console.WriteLine("Digite o nome:");
                    string nome = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o endereço:");
                    string endereco = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o CNPJ:");
                    string cnpj = (Console.ReadLine() ?? "");
                    var Empresa1 = new Empresa(nome, endereco, cnpj);
                    repoClientes.AdicionarCliente(Empresa1);
                }
            }
        break;
        case 2:
            {
                Console.WriteLine("Escolha o tipo de veículo:\n" +
                    "1 - Automóvel\n" +
                    "2 - Ônibus\n" +
                    "3 - Motocicleta");
                int opcao_veiculo = int.Parse(Console.ReadLine() ?? "");
                if (opcao_veiculo == 1)
                {
                    Console.WriteLine("Digite o codigo RENAVAM:");
                    string renavam = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o modelo:");
                    string modelo = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o total de KM rodado:");
                    int kmTotal = int.Parse((Console.ReadLine() ?? ""));

                    Console.WriteLine("Digite o valor da diária:");
                    double valorDiaria = double.Parse(Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o total do porta malas:");
                    int portaMalas = int.Parse((Console.ReadLine() ?? ""));

                    var automovel1 = new Automovel(renavam, modelo, kmTotal, valorDiaria, portaMalas);
                    repoVeiculos.AdicionarVeiculo(automovel1);
                }
                else if (opcao_veiculo == 2)
                {
                    Console.WriteLine("Digite o codigo RENAVAM:");
                    string renavam = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o modelo:");
                    string modelo = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o total de KM rodado:");
                    int kmTotal = int.Parse((Console.ReadLine() ?? ""));

                    Console.WriteLine("Digite o valor da diária:");
                    double valorDiaria = double.Parse(Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o total de eixos:");
                    int eixos = int.Parse((Console.ReadLine() ?? ""));

                    var onibus1 = new Onibus(renavam, modelo, kmTotal, valorDiaria, eixos);
                    repoVeiculos.AdicionarVeiculo(onibus1);
                }
                else if (opcao_veiculo == 3)
                {
                    Console.WriteLine("Digite o codigo RENAVAM:");
                    string renavam = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o modelo:");
                    string modelo = (Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o total de KM rodado:");
                    int kmTotal = int.Parse((Console.ReadLine() ?? ""));

                    Console.WriteLine("Digite o valor da diária:");
                    double valorDiaria = double.Parse(Console.ReadLine() ?? "");

                    Console.WriteLine("Digite o total de cilindradas: ");
                    int cilindradas = int.Parse((Console.ReadLine() ?? ""));

                    var motocicleta1 = new Motocicleta(renavam, modelo, kmTotal, valorDiaria, cilindradas);
                    repoVeiculos.AdicionarVeiculo(motocicleta1);
                }
            }
            break;
        case 3:
            {
                Console.WriteLine("Digite o RENAVAM do veiculo: ");
                string renavam= (Console.ReadLine() ?? "");
                Veiculo? veiculo = repoVeiculos.BuscarPorCodigo(renavam);
                if (veiculo == null)
                {
                    Console.WriteLine("Veículo não encontrado!");
                    break;
                }
                if (veiculo.Locado == true)
                {
                    Console.WriteLine("Veículo já está locado!");
                    break;
                }

                Console.WriteLine("Digite o codigo do cliente: ");
                string codigo = (Console.ReadLine() ?? "");
                Cliente? cliente = repoClientes.BuscarPorCodigo(codigo);
                if (cliente == null)
                {
                    Console.WriteLine("Cliente não encontrado!");
                    break;
                }
                Console.WriteLine("Digite o numero de diarias: ");
                int NumeroDiarias = int.Parse((Console.ReadLine() ?? ""));

                Console.WriteLine("Digite a data e hora: ");
                DateTime DataHoraRetirada = DateTime.Parse((Console.ReadLine() ?? ""));
                var locacao1 = new Locacao(cliente, veiculo, DataHoraRetirada, NumeroDiarias);
                veiculo.IniciarLocacao();
                repoLocacoes.AdicionarLocacao(locacao1);
                Console.WriteLine($"Valor total da locação: {locacao1.ValorTotalLocacao()}");
            }
            break;

        case 4:
            {
                foreach (var locacao in repoLocacoes.ObterTodas())
                {
                    if (locacao.Veiculo.Locado == true)
                    {
                        Console.WriteLine("Digite a quilometragem rodada:");
                        int quilometragemRodada = int.Parse(Console.ReadLine() ?? "");
                        locacao.EncerrarLocacao(quilometragemRodada);
                    }
                }
            }
            break;

        case 5:
            {
                foreach (var cliente in repoClientes.ObterTodos())
                {
                    Console.WriteLine($"Codigo: {cliente.Codigo} - Nome: {cliente.Nome} - Endereço: {cliente.Endereco}");
                    if (cliente is PessoaFisica pf)
                    {
                        Console.WriteLine($"CPF: {pf.Cpf} - Idade: {pf.Idade}");
                    }
                    else if (cliente is Empresa emp)
                    {
                        Console.WriteLine($"CNPJ: {emp.Cnpj}");
                    }
                }
            }
            break;

        case 6:
            {
                foreach (var veiculo in repoVeiculos.ObterTodos())
                {
                    Console.WriteLine($"RENAVAM: {veiculo.CodigoRenavam} - Modelo: {veiculo.Modelo} - KM: {veiculo.QuilometragemTotal} - Diária: {veiculo.ValorDiaria} - Locado: {veiculo.Locado}");
                    if (veiculo is Automovel auto)
                    {
                        Console.WriteLine($"Porta-malas: {auto.CapacidadePortaMalas}");
                    }
                    else if (veiculo is Onibus on)
                    {
                        Console.WriteLine($"Eixos: {on.NumeroEixos}");
                    }
                    else if (veiculo is Motocicleta moto)
                    {
                        Console.WriteLine($"Cilindradas: {moto.Cilindradas}");
                    }
                }
            }
            break;

        case 7:
            {
                foreach (var locacao in repoLocacoes.ObterTodas())
                {
                    string estado = locacao.Veiculo.Locado ? "Ativa" : "Encerrada";
                    Console.WriteLine($"Codigo: {locacao.Codigo} - Cliente: {locacao.Cliente.Nome} - Veiculo: {locacao.Veiculo.Modelo} - Retirada: {locacao.DataHoraRetirada} - Diarias: {locacao.NumeroDiarias} - Estado: {estado}");
                }
            }
            break;
        case 8: return;
    }
}