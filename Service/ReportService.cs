using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;

namespace BlazorApp1FrontEndSIGA.Relatorio.Relatorio
{
    public class ReportService
    {
        private readonly GradeService _gradeService;

        public ReportService(GradeService gradeService)
        {
            _gradeService = gradeService;
        }

        public async Task<List<Grade>> GeneratePerformanceReports(string disciplineId)
        {
            return await _gradeService.GetGradesByDiscipline(disciplineId);
        }
    }

}
