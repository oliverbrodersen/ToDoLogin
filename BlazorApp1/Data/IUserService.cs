using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}