using IdentityServer4.Models;
using System.Collections.Generic;

namespace AuthServer.Settings
{
    static public class Config
    {
        #region Scopes
        //API'larda kullanılacak izinleri tanımlar.
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
        {
            new ApiScope("Basket.Write","Sepet yazma izni"),
            new ApiScope("Basket.Read","Sepet okuma izni"),
            new ApiScope("Order.Write","Sipariş yazma izni"),
            new ApiScope("Order.Read","Sipariş okuma izni"),
        };
        }
        #endregion
        #region Resources
        //API'lar tanımlanır.
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
        {
            new ApiResource("Basket"){ Scopes = { "Basket.Write", "Basket.Read" } },
            new ApiResource("Order"){ Scopes = { "Order.Write", "Order.Read" } }
        };
        }
        #endregion
        #region Clients
        //API'ları kullanacak client'lar tanımlanır.
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
        {
            new Client
                    {
                        ClientId = "BasketAPI",
                        ClientName = "BasketAPI",
                        ClientSecrets = { new Secret("basket".Sha256()) },
                        AllowedGrantTypes = { GrantType.ClientCredentials },
                        AllowedScopes = { "Basket.Write", "Basket.Read" }
                    },
            new Client
                    {
                        ClientId = "OrderAPI",
                        ClientName = "OrderAPI",
                        ClientSecrets = { new Secret("order".Sha256()) },
                        AllowedGrantTypes = { GrantType.ClientCredentials },
                        AllowedScopes = { "Order.Write", "Order.Read" }
                    }
        };
        }
        #endregion
    }
}
