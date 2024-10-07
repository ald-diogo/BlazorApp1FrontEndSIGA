using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;
using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Layout;


namespace BlazorApp1FrontEndSIGA.Entidades
{
    public class Evaluation
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
    }
}
