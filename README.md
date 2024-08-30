# ProjetoPessoal

### Eu desenvolvi este projeto para treinar minha agilidade com desenvolvimento. Me desafiei fazer uma APIRestful em menos de 2 horas com OAuth2.0.
### Disponibilizarei o clientId e cleintSecret para buscar o token.

Primeiramente, vocês terão que fazer uma migration para o banco de dados MySQL. O Server: localhost; usuarioId: root. Se houver senha, coloque no arquivo `appsettings.json` em `ConnectionStrings:BaseConnection`.

A migration deve realizar o seguinte comando: `update-database` em `Console do Gerenciado de Pacotes`.

Caso não ache, siga o passo a passo a seguir:
- Vá até à `Ferramentas` > `Gerenciado de Pacotes do Nuget` > `Console do Gerenciado de Pacotes`.

Agora você pode executar o `update-database`

#

### Caso use o Visual Studio Code, realize os seguintes comandos:
```
git clone https://github.com/GOD-ZOOM-REVERSE/ProjetoPessoal-APIRestfull.git \
cd ProjetoPessoal-APIRestfull \
dotnet tool install --global dotnet-ef \
dotnet ef database update \
dotnet run
```

> [!WARNING]
> Certifique-se de que o `appsettings.json` está correto!
> Se houver senha, coloque o `pwd:{senha}`.

# Gerando Token

### Aqui, você irá gerar o token pelo connect do IdentityServer

Quando você executar o projeto, entre na rota `https://localhost:44310/swagger`.
Se tentar acessar uma Rota da API sem um token Bearer, você irá receber `401 (Unnauthorized)`.

Para resolver, faça o seguinte:
- Abra o Postman;
- Vá até a aba `Authorization`;
- coloque `OAuth2.0`;
- Desce um pouco e verá um formulário. Siga passo a passo agora:
  - no `Granty Type` coloque `Client Credentials`;
  - em `Access Token URL` coloque: `https://localhost:44310/connect/token`;
  - `Client ID` e `Client Secret` coloque: `client` e `my_super_secret`, respectivamente;
  - por fim, em `Scope` coloque: `api1`.

O Token gerado, copie e, no swagger, cole com o Bearer [space] na frente.

> [!NOTE]
> Futuramente colocarei uma api que gerará um token de acesso para mais facibilidade.
