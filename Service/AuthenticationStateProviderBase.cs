using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Relatorio;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;
using System.Threading.Tasks;
using System.Security.Claims;
using static BlazorApp1FrontEndSIGA.CustomAuthenticationStateProvider;

namespace BlazorApp1FrontEndSIGA.Service
{ 
    namespace BlazorApp1FrontEndSIGA.Service
    {
        public class CustomAuthenticationStateProvider : AuthenticationStateProvider
        {
            private readonly IUserService _userService;

            public CustomAuthenticationStateProvider(IUserService userService)
            {
                _userService = userService;
            }

            public async Task<AuthenticationState> GetCustomAuthenticationStateAsync()
            {
                var identity = new ClaimsIdentity();
                var user = await _userService.GetUserByIdAsync("some-user-id"); // Simulação de usuário logado

                if (user != null)
                {
                    identity = new ClaimsIdentity(new[]
                    {
                      new Claim(ClaimTypes.Name, user.Name),
                      new Claim(ClaimTypes.Role, user.Role)
                    },   "apiauth_type");
                }

                var userPrincipal = new ClaimsPrincipal(identity);
                return new AuthenticationState(userPrincipal);
            }
        }

    }
} 