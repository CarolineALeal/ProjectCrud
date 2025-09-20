# ProjectCrud
ProjectCrud é uma aplicação **.NET 8.0 Web API** para gerenciamento de entidades *Person* utilizando operações CRUD. Ele utiliza **Entity Framework Core** com **MySQL** para persistência de dados.

## Funcionalidades
- API RESTful para gerenciamento de *Person* (Criar, Ler, Atualizar, Deletar)
- Integração com Entity Framework Core
- Suporte a banco de dados MySQL
- **Swagger UI** para documentação e testes da API

## Estrutura do Projeto
- **PersonController.cs**: Endpoints da API para operações de *Person*
- **Person.cs**: Definição da entidade *Person*
- **AppDbContext.cs**: Configuração do contexto do banco de dados
- **Migrations**: Arquivos de migração do Entity Framework
- **appsettings.json**: Configuração da aplicação
- **ProjectCrud.csproj**: Arquivo de configuração do projeto

## Como Começar
1. Clone o repositório.
2. Atualize a string de conexão do MySQL no arquivo **appsettings.json**.
3. Execute as migrações do banco de dados:
4. Inicie a API:
5. Acesse o Swagger UI em: `http://localhost:<porta>/swagger`

## Requisitos
- **.NET 8.0 SDK**
- **MySQL Server**
