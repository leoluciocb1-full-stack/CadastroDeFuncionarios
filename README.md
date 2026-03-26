👨‍💼 Controle de Funcionários - C#

Sistema de cadastro de funcionários desenvolvido em C# com foco em Programação Orientada a Objetos (POO), organização em camadas e exportação de dados em XML e JSON.

📚 Conceitos aplicados

Este projeto demonstra na prática:

✅ Herança
✅ Composição entre classes
✅ Enumerações (enum)
✅ Arquitetura em camadas
✅ Serialização em XML
✅ Serialização em JSON
✅ Boas práticas de organização de código

🧱 Estrutura do Projeto
ControleDeFuncionarios
│
├── Controllers
│   └── FuncionarioController.cs
│
├── Entities
│   ├── Pessoa.cs
│   ├── Funcionario.cs
│   └── Empresa.cs
│
├── Enums
│   └── TipoContratacao.cs
│
├── Services
│   └── FuncionarioService.cs
│
└── Program.cs

🧠 Conceitos de POO Utilizados
🔹 Herança

A classe Funcionario herda de Pessoa, reutilizando propriedades comuns.

public class Funcionario : Pessoa

Isso evita repetição de código e facilita manutenção.

🔹 Composição

Um funcionário tem uma empresa, representado pela classe Empresa.

public Empresa Empresa { get; set; } = new();

Relacionamento: Funcionário → Empresa (1 para 1)

🔹 Enum (Tipo de Contratação)

O enum padroniza os tipos de contratação:

public enum TipoContratacao
{
    JovemAprendiz = 1,
    Estagiario = 2,
    CLT = 3,
    Terceirizado = 4,
    PrestadorServico = 5
}

Vantagens:

Código mais seguro
Evita valores inválidos
Mais legível

🏗️ Arquitetura em Camadas

O projeto foi dividido em camadas para melhor organização:

📂 Entities

Contém as classes de modelo de dados.

Pessoa
Funcionario
Empresa

🎮 Controllers

Responsável pela entrada de dados e fluxo da aplicação.

FuncionarioController

⚙️ Services

Contém regras de negócio e operações.

Exportação XML
Exportação JSON

🧩 Enums

Contém enumerações utilizadas no sistema.

💾 Exportação de Dados

O sistema salva automaticamente os dados cadastrados em:

📄 XML
📄 JSON

Local padrão:

C:\temp\

Exemplo de arquivos gerados:

funcionario_8f23a1.xml
funcionario_8f23a1.json

▶️ Como Executar
Clone o repositório
git clone https://github.com/seu-usuario/ControleDeFuncionarios.git
Abra no Visual Studio ou VS Code
Execute o projeto
Preencha os dados solicitados no console

🖥️ Exemplo de Execução
CADASTRO DE FUNCIONÁRIO:

Informe o nome do funcionário....: João da Silva
Informe o cpf....................: 12345678900
Informe a matrícula..............: 2024001
Data de admissão (dd/MM/yyyy)....: 10/01/2024
Informe o salário................: 3500
Informe razão social da empresa..: Empresa XPTO
Informe o cnpj da empresa........: 12345678000199

🎯 Objetivo Educacional

Este projeto foi desenvolvido para ensinar:

Programação Orientada a Objetos
Organização em camadas
Serialização de dados
Boas práticas em C#

🚀 Melhorias Futuras
 Validação de CPF
 Validação de CNPJ
 Persistência em banco SQL
 Interface Windows Forms
 API ASP.NET
 Listagem de funcionários
 Exclusão de registros
 Atualização de dados

👨‍🏫 Conteúdo Didático

Este projeto demonstra:

Herança (Pessoa → Funcionario)
Composição (Funcionario → Empresa)
Enum (TipoContratacao)
Arquitetura em Camadas
Serialização XML
Serialização JSON

📄 Licença

Projeto criado para fins educacionais 🎓
