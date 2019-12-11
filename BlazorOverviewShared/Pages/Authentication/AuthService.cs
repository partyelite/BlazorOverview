using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;

namespace BlazorOverviewShared.Pages.Authentication
{
    public class AuthService
    {

        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }


        public async Task<bool> Login(string name)
        {
            if (name == "Admin" || name == "User")
            {
                var token = $"Named {name}, {name}";
                await _localStorage.SetItemAsync("authToken", token);
                ((CustomAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(token);
                return true;
            }

            return false;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((CustomAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
        }
    }
}
