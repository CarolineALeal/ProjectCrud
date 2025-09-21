Write-Host "Inicializando migrations e atualizando o banco..."

# Define variável de ambiente local (host)
if (-not (Test-Path Env:ConnectionStrings__AppDbConnectionString)) {
    $env:ConnectionStrings__AppDbConnectionString = "Server=127.0.0.1;Port=3307;Database=ProjectCrudDb;Uid=root;Pwd=projectcrud123;"
}

# Remove migrations antigas (opcional)
if (Test-Path ".\Migrations") {
    Remove-Item -Recurse -Force ".\Migrations"
}

# Cria nova migration
dotnet ef migrations add Inicial

# Atualiza o banco
dotnet ef database update

Write-Host "Banco pronto!"
