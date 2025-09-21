# ProjectCrud

ProjectCrud é uma aplicação **.NET 8.0 Web API** para gerenciamento de entidades `Person` utilizando operações CRUD. Ele utiliza **Entity Framework Core** com **MySQL** para persistência de dados.

## Funcionalidades

- API RESTful para gerenciamento de `Person` (Criar, Ler, Atualizar, Deletar)
- Integração com **Entity Framework Core**
- Suporte a banco de dados **MySQL**
- **Swagger UI** para documentação e testes da API
- Suporte a execução via **Docker**

## Estrutura do Projeto

- `Controllers/PersonController.cs`: Endpoints da API para operações de `Person`
- `Models/Person.cs`: Definição da entidade `Person`
- `Data/AppDbContext.cs`: Configuração do contexto do banco de dados
- `Migrations/`: Arquivos de migração do Entity Framework
- `Init-Database.ps1`: Script para inicializar o banco de dados e aplicar migrations
- `appsettings.json`: Configuração padrão da aplicação
- `ProjectCrud.csproj`: Arquivo de configuração do projeto

## Como Começar

### 1. Clonar o repositório
```bash
git clone <https://github.com/CarolineALeal/ProjectCrud.git>
cd ProjectCrud
```

### 2. Rodar com Docker (recomendado)
```bash
docker-compose up --build
```

### 3. Inicializar o banco de dados
Após subir os containers, execute o script para criar o banco e aplicar as migrations:
```powershell
.\Init-Database.ps1
```

### 4. Acessar a API
Acesse o **Swagger UI** para testar os endpoints:
```
http://localhost:5000/swagger
```

### 5. Configurações
- O arquivo `appsettings.json` contém as configurações padrão da aplicação
- O arquivo `appsettings.Development.json` é ignorado pelo Git e pode conter dados sensíveis (como senha local do MySQL)

## Requisitos

- **.NET 8.0 SDK**
- **MySQL Server**
- **Docker** (opcional, mas recomendado para facilitar setup)