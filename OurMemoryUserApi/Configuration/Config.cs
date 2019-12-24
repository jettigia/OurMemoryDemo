using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace OurMemoryUserApi.Configuration
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
            };
        }

        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
            {
                new ApiResource("api", "Demo API")
                {
                    ApiSecrets = { new Secret("secret".Sha256()) }
                },

                // PolicyServer demo
                new ApiResource("policyserver.runtime"),
                new ApiResource("policyserver.management")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "m2m",
                    ClientName = "Machine to machine (client credentials)",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "api", "policyserver.runtime", "policyserver.management" },
                },
                new Client
                {
                    ClientId = "m2m.short",
                    ClientName = "Machine to machine with short access token lifetime (client credentials)",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "api" },
                    AccessTokenLifetime = 75
                },

                new Client
                {
                    ClientId = "interactive.confidential",
                    ClientName = "Interactive client (Code with PKCE)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    ClientSecrets = { new Secret("secret".Sha256()) },
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    RequirePkce = true,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse
                },
                new Client
                {
                    ClientId = "interactive.confidential.short",
                    ClientName = "Interactive client with short token lifetime (Code with PKCE)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    ClientSecrets = { new Secret("secret".Sha256()) },
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    RequirePkce = true,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse,
                    AccessTokenLifetime = 75
                },

                new Client
                {
                    ClientId = "interactive.public",
                    ClientName = "Interactive client (Code with PKCE)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    RequireClientSecret = false,
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse
                },
                new Client
                {
                    ClientId = "interactive.public.short",
                    ClientName = "Interactive client with short token lifetime (Code with PKCE)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    RequireClientSecret = false,
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse,
                    AccessTokenLifetime = 75
                },

                new Client
                {
                    ClientId = "device",
                    ClientName = "Device Flow Client",

                    AllowedGrantTypes = GrantTypes.DeviceFlow,
                    RequireClientSecret = false,

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "email", "api" }
                },


                // legacy
                new Client
                {
                    ClientId = "native.hybrid",
                    ClientName = "Native Client (Hybrid with PKCE)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    RequireClientSecret = false,
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.Hybrid,
                    RequirePkce = true,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse
                },
                new Client
                {
                    ClientId = "server.hybrid",
                    ClientName = "Server-based Client (Hybrid)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    ClientSecrets = { new Secret("secret".Sha256()) },
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse
                },
                new Client
                {
                    ClientId = "server.hybrid.short",
                    ClientName = "Server-based Client (Hybrid)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    ClientSecrets = { new Secret("secret".Sha256()) },
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse,
                    AccessTokenLifetime = 70,
                },
                new Client
                {
                    ClientId = "native.code",
                    ClientName = "Native Client (Code with PKCE)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    RequireClientSecret = false,
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    RequirePkce = true,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse
                },
                new Client
                {
                    ClientId = "server.code",
                    ClientName = "Server Client (Code)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    ClientSecrets = { new Secret("secret".Sha256()) },
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse
                },
                new Client
                {
                    ClientId = "server.code.short",
                    ClientName = "Server Client (Code)",

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    ClientSecrets = { new Secret("secret".Sha256()) },
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse,
                    AccessTokenLifetime = 70
                },

                // server to server
                new Client
                {
                    ClientId = "client",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "api" },
                },

                // SPA per new security guidance
                new Client
                {
                    ClientId = "spa",
                    ClientName = "SPA (Code + PKCE)",

                    RequireClientSecret = false,
                    RequireConsent = false,

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    AllowedGrantTypes = GrantTypes.Code,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse
                },
                new Client
                {
                    ClientId = "spa.short",
                    ClientName = "SPA (Code + PKCE)",

                    RequireClientSecret = false,
                    RequireConsent = false,

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    AllowedGrantTypes = GrantTypes.Code,
                    AllowedScopes = { "openid", "profile", "email", "api" },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.OneTimeOnly,
                    AccessTokenLifetime = 70
                },

                // implicit (e.g. SPA or OIDC authentication)
                new Client
                {
                    ClientId = "implicit",
                    ClientName = "Implicit Client",
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false,

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },
                    FrontChannelLogoutUri = "http://localhost:5000/signout-idsrv", // for testing identityserver on localhost

                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = { "openid", "profile", "email", "api" },
                },

                // implicit using reference tokens (e.g. SPA or OIDC authentication)
                new Client
                {
                    ClientId = "implicit.reference",
                    ClientName = "Implicit Client using reference tokens",
                    AllowAccessTokensViaBrowser = true,

                    AccessTokenType = AccessTokenType.Reference,
                    RequireConsent = false,

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = { "openid", "profile", "email", "api" },
                },

                // implicit using reference tokens (e.g. SPA or OIDC authentication)
                new Client
                {
                    ClientId = "implicit.shortlived",
                    ClientName = "Implicit Client using short-lived tokens",
                    AllowAccessTokensViaBrowser = true,

                    AccessTokenLifetime = 70,
                    RequireConsent = false,

                    RedirectUris = { "https://notused" },
                    PostLogoutRedirectUris = { "https://notused" },

                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = { "openid", "profile", "email", "api" },
                },
            };
        }

        public static List<TestUser> TestUsers = new List<TestUser>
        {
            new TestUser { SubjectId = "1", Username = "alice", Password = "alice",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Alice Smith"),
                    new Claim(JwtClaimTypes.GivenName, "Alice"),
                    new Claim(JwtClaimTypes.FamilyName, "Smith"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser { SubjectId = "11", Username = "bob", Password = "bob",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Bob Smith"),
                    new Claim(JwtClaimTypes.GivenName, "Bob"),
                    new Claim(JwtClaimTypes.FamilyName, "Smith"),
                    new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json),
                    new Claim("location", "somewhere")
                }
            }
        };
    }
}
