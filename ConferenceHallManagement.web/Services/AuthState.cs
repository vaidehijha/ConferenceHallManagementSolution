using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace ConferenceHallManagement.Web.Services
{
    public class AuthState : AuthenticationStateProvider
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private ClaimsPrincipal _currentUser = new(new ClaimsIdentity());

        public bool IsLoggedIn { get; private set; }
        public string? UserId { get; private set; }
        public string? Role { get; private set; }  // "User" / "Admin"

        public event Action? OnAuthStateChanged;

        public AuthState(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public async Task InitializeAsync()
        {
            try
            {
                var userIdResult = await _sessionStorage.GetAsync<string>("userId");
                var roleResult = await _sessionStorage.GetAsync<string>("role");

                if (userIdResult.Success && roleResult.Success && 
                    !string.IsNullOrEmpty(userIdResult.Value))
                {
                    SetUserInternal(userIdResult.Value, roleResult.Value);
                }
            }
            catch
            {
                // If session storage fails, user stays logged out
            }
        }

        public async Task SetUser(string userId, string role)
        {
            await _sessionStorage.SetAsync("userId", userId);
            await _sessionStorage.SetAsync("role", role);
            SetUserInternal(userId, role);
        }

        private void SetUserInternal(string userId, string role)
        {
            IsLoggedIn = true;
            UserId = userId;
            Role = role;

            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, userId),
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(ClaimTypes.Role, role)
            }, "CustomAuth");

            _currentUser = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_currentUser)));
            OnAuthStateChanged?.Invoke();
        }

        public async Task Logout()
        {
            await _sessionStorage.DeleteAsync("userId");
            await _sessionStorage.DeleteAsync("role");
            
            IsLoggedIn = false;
            UserId = null;
            Role = null;

            _currentUser = new ClaimsPrincipal(new ClaimsIdentity());
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_currentUser)));
            OnAuthStateChanged?.Invoke();
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return Task.FromResult(new AuthenticationState(_currentUser));
        }
    }
}
