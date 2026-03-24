//Localização da classe dentro do projeto.
namespace CadastroDeFuncionarios.Entidades
{
    /*
    * Declaração da classe
    */
    public class Funcionario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public DateTime DataAdmissao { get; set; } = DateTime.Now.Date;
        public string Cargo { get; set; } = string.Empty;
        public decimal Salario { get; set; }
    }
}