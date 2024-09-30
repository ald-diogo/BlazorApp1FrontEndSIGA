using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;

namespace BlazorApp1FrontEndSIGA.Service
{
    public class FeedbackService
    {
        private readonly List<Pages.Feedback> feedbacks = new List<Pages.Feedback>();

        public Task AddFeedback(Pages.Feedback feedback)
        {
            feedback.Id = feedbacks.Count + 1;
            feedback.Date = DateTime.Now;
            feedbacks.Add(feedback);
            return Task.CompletedTask;
        }

        public Task<List<Pages.Feedback>> GetFeedbacks()
        {
            return Task.FromResult(feedbacks);
        }
    }



}
