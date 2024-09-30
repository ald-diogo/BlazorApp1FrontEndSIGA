using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;

namespace BlazorApp1FrontEndSIGA.Service
{
    public class GradeService
    {
        private readonly List<Grade> grades = new List<Grade>();

        public Task AddGrade(Grade grade)
        {
            grades.Add(grade);
            return Task.CompletedTask;
        }

        public Task<List<Grade>> GetGradesByDiscipline(string disciplineId)
        {
            return Task.FromResult(grades.Where(g => g.DisciplineId == disciplineId).ToList());
        }

        public Task<double> CalculateAverageGrade(string disciplineId)
        {
            var grades = grades.Where(g => g.DisciplineId == disciplineId).ToList();
            return Task.FromResult(grades.Average(g => g.Value));
        }
    }

}
