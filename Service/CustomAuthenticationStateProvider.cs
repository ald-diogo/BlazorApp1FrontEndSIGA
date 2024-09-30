using System.Security.Claims;
using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;


namespace BlazorApp1FrontEndSIGA.Service
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly UserService _userService;

        public CustomAuthenticationStateProvider(UserService userService)
        {
            _userService = userService;
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            var user = _userService.GetUserById("some-user-id").Result; // Simulação de usuário logado

            if (user != null)
            {
                identity = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, user.Role)
            }, "apiauth_type");
            }

            var userPrincipal = new ClaimsPrincipal(identity);
            return Task.FromResult(new AuthenticationState(userPrincipal));
        }
    }

    public class AuthenticationState
    {
        public AuthenticationState(ClaimsPrincipal userPrincipal)
        {
            UserPrincipal = userPrincipal;
        }

        public ClaimsPrincipal UserPrincipal { get; }
    }

    public class AuthenticationStateProvider
    {
    }
}
