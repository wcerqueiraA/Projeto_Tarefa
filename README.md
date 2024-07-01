# Projeto TarefaApp

Este projeto é uma aplicação web desenvolvida em ASP.NET Core Razor Pages para gerenciar tarefas.

## Descrição

O TarefaApp é uma aplicação simples para gerenciar tarefas, permitindo aos usuários criar, visualizar, editar e excluir tarefas com descrição e data associada.
Dependências

    - Linguagem: C#
    - .NET Core 7.0
    - Visual Studio 2022 para desenvolvimento
    - SQL Server Management Studio 2022

## Instalação

    1. Clone o repositório:

    bash
      git clone https://github.com/seu-usuario/TarefaApp.git

    2. Abra o arquivo de solução TarefaApp.sln no Visual Studio.

    3. Configure a conexão com o banco de dados SQL Server no arquivo appsettings.json:


    "ConnectionStrings": {
      "DefaultConnection": "sua-string-de-conexao-aqui"
    }

    4. Compile o projeto e execute a aplicação.

## Estrutura do Projeto
### O projeto está estruturado da seguinte forma:

    - Pages/: Contém as páginas Razor (.cshtml e .cshtml.cs) que compõem a interface do usuário.
    - Models/: Contém a definição da classe Tarefa que representa as tarefas a serem gerenciadas.
    - Context/: Contém o AppDbContext, que define o contexto do banco de dados e configura a conexão com o SQL Server.
    - Migrations/: Contém as classes de migração do Entity Framework Core para criação e atualização do banco de dados.
    - wwwroot/: Contém arquivos estáticos como CSS e JavaScript.
    - _Layout.cshtml: Layout padrão usado por todas as páginas, definindo a estrutura comum, estilos e scripts compartilhados.

## Funcionalidades

    Adicionar, editar, visualizar e excluir tarefas.
    Validação de entrada para garantir dados corretos.
    Layout responsivo usando Bootstrap para melhor experiência do usuário.

## Uso

    Acesse a página inicial para visualizar todas as tarefas cadastradas.
    Clique em "Criar" para adicionar uma nova tarefa.
    Clique em "Editar" ou "Excluir" ao lado de cada tarefa para modificar ou remover.

## Contribuição
Sinta-se à vontade para contribuir com melhorias. Para isso, siga os passos:

    1. Fork o repositório.
    2. Crie uma branch com a sua feature (git checkout -b feature/MinhaFeature).
    3. Commit suas mudanças (git commit -am 'Adiciona nova feature').
    4. Push para a branch (git push origin feature/MinhaFeature).
    5. Crie um novo Pull Request.

## Direitos Autorais e Licença

© 2024 Wellington Cerqueira Araujo
Consulte o arquivo LICENSE para mais detalhes sobre a licença do código-fonte deste projeto.
