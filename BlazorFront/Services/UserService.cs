using BlazorFront.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorFront.Services;

public class UserService : ComponentBase
{
    private readonly ApplicationContext _context;
    private readonly NavigationManager _navigationManager;

    public UserService(ApplicationContext context,
                       NavigationManager navigationManager)
    {
        _context = context;
        _navigationManager = navigationManager;
    }

    public async Task<bool> GetUserByEmail(User user)
    {
        if (!UserExists(user.Email))
        {
            _context.Users.Add(new Models.User
            {
                Email = user.Email,
                Password = user.Password,
            });
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("/profile");
            return true;
        }
        else if (!PasswordCorrect(user))
        {
            _navigationManager.NavigateTo("/counter");
            return false;
        }
        else
        {
            _navigationManager.NavigateTo("/profile");
            return true;
        }
    }

    private bool UserExists(string email)
    {
        return _context.Users.Any(e => e.Email == email);
    }

    private bool PasswordCorrect(User user)
    {
        var bdUser = _context.Users.SingleOrDefault(t => t.Email == user.Email);
        var res = bdUser != null ? bdUser.Password == user.Password : false;
        return res;
    }
}
