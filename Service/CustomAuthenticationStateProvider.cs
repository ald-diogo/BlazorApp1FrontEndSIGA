using System.Security.Claims;
using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;
using System.Security.Claims;
using System.Threading.Tasks;
using static BlazorApp1FrontEndSIGA.Service.CustomAuthenticationStateProvider;

namespace BlazorApp1FrontEndSIGA.Service
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly UserService _userService;

        public CustomAuthenticationStateProvider(UserService userService)
        {
            _userService = userService;
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

    public class AuthenticationStateProvider : AuthenticationStateProviderBase
    {
    }

    public class AuthenticationStateProviderBase
    {
        private async Task<bool> GetCustomAuthenticationStateAsync()
        {
            throw new NotImplementedException();
        }
    }
}

