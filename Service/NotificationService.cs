using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;

namespace BlazorApp1FrontEndSIGA.Service
{
    public class NotificationService
    {
        public event Action<string> OnNotify;

        public void Notify(string message)
        {
            OnNotify?.Invoke(message);
        }
    }

}
