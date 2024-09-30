using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;

namespace BlazorApp1FrontEndSIGA.Service
{
    public class GreetingService
    {
        public string GetGreeting()
        {
            var hour = DateTime.Now.Hour;
            if (hour < 12) return "Bom dia!";
            if (hour < 18) return "Boa tarde!";
            return "Boa noite!";
        }
    }

}
