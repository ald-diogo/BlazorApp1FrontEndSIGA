using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;
using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Layout;
using Microsoft;

namespace BlazorApp1FrontEndSIGA.Entidades
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
