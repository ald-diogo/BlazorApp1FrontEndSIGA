using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;

namespace BlazorApp1FrontEndSIGA.Service
{
    public class ThemeService
    {
        public string CurrentTheme { get; set; } = "light";

        public void ChangeTheme(string theme)
        {
            CurrentTheme = theme;
        }
    }

}
