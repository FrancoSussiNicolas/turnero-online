using BlazorApp.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Shared;

namespace BlazorApp.Client.Auth
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly LocalStorageService localStorage;
        private readonly IJSRuntime jsRuntime;

        public AuthStateProvider(LocalStorageService localStorage, IJSRuntime jsRuntime)
        {
            this.localStorage = localStorage;
            this.jsRuntime = jsRuntime;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // Verificar si estamos en el cliente (no en pre-rendering)
            if (jsRuntime is IJSInProcessRuntime)
            {
                try
                {
                    var token = await localStorage.GetItemAsync("authToken");
                    if (!string.IsNullOrWhiteSpace(token))
                    {
                        SessionManager.SetSession(token);
                        var handler = new JwtSecurityTokenHandler();
                        var jwt = handler.ReadJwtToken(token);
                        var identity = new ClaimsIdentity(jwt.Claims, "jwt");
                        var user = new ClaimsPrincipal(identity);
                        return new AuthenticationState(user);
                    }
                }
                catch (InvalidOperationException)
                {
                    // JS Interop no disponible aún (pre-rendering)
                }
            }

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

        public async Task MarkUserAsAuthenticated(string token)
        {
            await localStorage.SetItemAsync("authToken", token);
            SessionManager.SetSession(token);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public async Task MarkUserAsLoggedOut()
        {
            await localStorage.RemoveItemAsync("authToken");
            SessionManager.ClearSession();
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()))));
        }
    }
}