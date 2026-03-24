using CadastroDeFuncionarios.Entidades;
using CadastroDeFuncionarios.Repositories;

Console.WriteLine("\nSeja bem vindo ao sistema de cadastro de funcionários.\n");
Console.WriteLine("\tPreencha os campos abaixo para cadastrar o funcionário:\n");

//Criando um objeto da classe Funcionário:
var funcionario = new Funcionario();

Console.Write("\tInforme o nome do funcionário...........: ");
funcionario.Nome = Console.ReadLine();

Console.Write("\tInforme o Cpf...........................: ");
funcionario.Cpf = Console.ReadLine();

Console.Write("\tInforme a matrícula.....................: ");
funcionario.Matricula = Console.ReadLine();

Console.Write("\tInforme a data da admissão (dd/mm/aaaa).: ");
funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());

Console.Write("\tInforme o cargo.........................: ");
funcionario.Cargo = Console.ReadLine();

Console.Write("\tInforme o salario.......................: ");
funcionario.Salario = decimal.Parse(Console.ReadLine() ?? "0");


//Imprimindo os dados do funcionário
Console.WriteLine("\nDados do funcionário:");
Console.WriteLine("\tId do funcionario.......: " + funcionario.Id);
Console.WriteLine("\tNome....................: " + funcionario.Nome);
Console.WriteLine("\tCpf.....................: " + funcionario.Cpf);
Console.WriteLine("\tMatricula...............: " + funcionario.Matricula);
Console.WriteLine("\tData de admissão........: " + funcionario.DataAdmissao);
Console.WriteLine("\tCargo...................: " + funcionario.Cargo);
Console.WriteLine("\tSalário.................: " + funcionario.Salario);
//Confirmar com o usuário se ele deseja salvar os dados
Console.Write("\nDeseja salvar estes dados em arquivo? (S,N): ");
var opcao = Console.ReadLine();

//Verificar se o usuário confirmou ou não
if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
{
    //Criando um objeto da classe de serviço
    var funcionarioRepository = new FuncionarioRepository();

    //Exportando os dados do cliente:
    funcionarioRepository.ExportarDados(funcionario);

    Console.WriteLine("\nDados gravados com sucesso!");
}
else
{
    Console.WriteLine("\nFim do programa!");
}
Console.ReadKey();