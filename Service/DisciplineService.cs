using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;

namespace BlazorApp1FrontEndSIGA.Service
{
    public class DisciplineService
    {
        private readonly List<Discipline> disciplines = new List<Discipline>();

        public Task AddDiscipline(Discipline discipline)
        {
            discipline.Id = Guid.NewGuid().ToString();
            disciplines.Add(discipline);
            return Task.CompletedTask;
        }

        public Task<List<Discipline>> GetDisciplines()
        {
            return Task.FromResult(disciplines);
        }
    }

}
