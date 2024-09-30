using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;
using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Layout;

namespace BlazorApp1FrontEndSIGA.Entidades
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

}
