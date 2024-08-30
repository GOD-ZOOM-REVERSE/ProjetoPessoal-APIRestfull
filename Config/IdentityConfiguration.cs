using Duende.IdentityServer.Models;

namespace ProjetoPessoal.Config
{
    public static class IdentityConfiguration
    {
        public static IEnumerable<IdentityResource> identityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope(name: "api1", displayName: "My API")
            };

        public static IEnumerable<Client> clients => 
            new Client[]
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("my_super_secret".Sha256())
                    },
                    AllowedScopes = { "api1" }
                }
            };
    }
}
