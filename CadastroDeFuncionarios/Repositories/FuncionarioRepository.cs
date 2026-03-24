using CadastroDeFuncionarios.Entidades;

namespace CadastroDeFuncionarios.Repositories
{
    /*
    * Declaração da classe
    */
    public class FuncionarioRepository
    {
        /*
         * Método para receber um objeto da classe Funcionario e exportar os dados
         * gravando-os em um arquivo de extensão .TXT na máquina do usuário
         */
        public void ExportarDados(Funcionario funcionario)
        {

            //Criando ou abrindo um arquivo na máquina local
            var streamWriter = new StreamWriter("c:\\temp\\funcionarios.txt", true);


            //escrevendo os dados do funcionário no arquivo
            streamWriter.WriteLine("ID...........: " + funcionario.Id);
            streamWriter.WriteLine("NOME.........: " + funcionario.Nome);
            streamWriter.WriteLine("CPF..........: " + funcionario.Cpf);
            streamWriter.WriteLine("MATRICULA....: " + funcionario.Matricula);
            streamWriter.WriteLine("DATA ADMISSAO: " + funcionario.DataAdmissao.ToString("dd/MM/yyyy"));
            streamWriter.WriteLine("CARGO........: " + funcionario.Cargo);
            streamWriter.WriteLine("SALARIO......: " + funcionario.Salario);
            streamWriter.WriteLine("...");

            //fechar o arquivo
            streamWriter.Close();
        }
    }
}