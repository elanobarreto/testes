# testes

# Clonar os projetos para uma pasta local

## Para o projeto CbykApi (.Net) -> Executar os seguintes comandos
dotnet new webapi -n cbyk-api-net

dotnet add package Microsoft.EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore.Relacional

dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet ef migrations add createDb2


dotnet ef databse update
dotnet restore
dotnet ef migrations add Initial
dotnet ef database update

dotnet run

## Para o projeto AppAngular -> Executar os seguintes comandos

npm add ngx-bootstrap

npm audit

npm audit fix

ng g s Pessoas

ng g c Pessoas
