using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;
using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Layout;

namespace BlazorApp1FrontEndSIGA.Entidades
{
    public class Feedback
    {
        public string Id { get; set; }
        public string Comments { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
    }

}
