using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;

namespace BlazorApp1FrontEndSIGA.Service
{
    public class UserService
    {
        private readonly List<User> users = new List<User>();

        public Task RegisterUser(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            users.Add(user);
            return Task.CompletedTask;
        }

        public Task<User> GetUserById(string id)
        {
            return Task.FromResult(users.FirstOrDefault(u => u.Id == id));
        }
    }

}
