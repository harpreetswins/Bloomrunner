using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthIdentityServer
{
    public static class Configuration
    {
        public static IEnumerable<ApiResource> GetResources() => new List<ApiResource> {
            new ApiResource("Florists"),
            new ApiResource("Orders"),
            new ApiResource("Ocelot"),
        };

        public static IEnumerable<IdentityResource> GetIdentityResources() => new List<IdentityResource> {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResource
            {
                Name = "profile_pic",
                UserClaims = new List<string> { "profile_pic" }
            }
        };

        public static IEnumerable<Client> GetClients() => new List<Client> {
            new Client {
                ClientId="client_id_mvc",
                ClientSecrets={new Secret ("client_secret_mvc".ToSha256()) },
                AllowedGrantTypes=GrantTypes.Code,
                AllowedScopes={
                     "Orders",
                     "Categories",
                     IdentityServerConstants.StandardScopes.OpenId,
                     IdentityServerConstants.StandardScopes.Profile
                 },
                RedirectUris={ "https://localhost:5001/signin-oidc" },
                PostLogoutRedirectUris={ "https://localhost:5001/Home" },
                AllowOfflineAccess = true,
                RequireConsent = false,
            },
              new Client {
                    ClientId = "angular",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    AccessTokenLifetime = (3600*8),
                    RequireClientSecret = false,

                     RedirectUris = { "http://ditstekdemo.com/floristappdev/authrsp" },
                     PostLogoutRedirectUris = { "http://ditstekdemo.com/floristappdev/authrsp" },

                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        "profile",
                        "profile_pic",
                        "Orders",
                        "Ocelot",
                        "Florists"
                    },
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false,
                },
        };

    }
}
