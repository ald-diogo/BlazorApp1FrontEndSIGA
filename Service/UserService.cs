using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;

    namespace BlazorApp1FrontEndSIGA.Service
    {
      public interface IUserService
      {
        Task<User> GetUserByIdAsync(string userId);
      }

      public class UserService : IUserService
      {
        public async Task<User> GetUserByIdAsync(string userId)
        {
            // Simulação de uma chamada assíncrona para obter o usuário
            await Task.Delay(100); // Simula um atraso
            return new User { Name = "", Role = "Admin" };
        }
      }

     public class User
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }


    }


