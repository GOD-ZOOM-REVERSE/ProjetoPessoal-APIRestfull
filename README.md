# ProjetoPessoal

### Eu desenvolvi este projeto para treinar minha agilidade com desenvolvimento. Me desafiei fazer uma APIRestful em menos de 2 horas com OAuth2.0.
### Disponibilizarei o clientId e cleintSecret para buscar o token.

Primeiramente, vocês terão que fazer uma migration para o banco de dados MySQL. O Server: localhost; usuarioId: root. Se houver senha, coloque no arquivo `appsettings.json` em `ConnectionStrings:BaseConnection`.

A migration deve realizar o seguinte comando: `update-database`.

### Caso use o Visual Studio Code, realize os seguintes comandos:
```
git clone [https://github.com/GOD-ZOOM-REVERSE/ProjetoPessoal-APIRestfull.git] \
cd ProjetoPessoal-APIRestfull \
dotnet tool install --global dotnet-ef \
dotnet ef database update \
dotnet run
```

> [!WARNING]
> Certifique-se de que o `appsettings.json` está correto!
> Se houver senha, coloque o `pwd:{senha}`.
