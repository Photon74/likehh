using BlazorFront.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorFront.Services;

public class UserService : ComponentBase
{
    private readonly ApplicationContext _context;
    private readonly NavigationManager _navigationManager;
    private readonly StateService _stateService;

    public UserService(ApplicationContext context,
                       NavigationManager navigationManager,
                       StateService stateService)
    {
        _context = context;
        _navigationManager = navigationManager;
        _stateService = stateService;
    }

    public async Task<bool> GetUserByEmail(UserDto user)
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

    private bool PasswordCorrect(UserDto user)
    {
        var bdUser = _context.Users.SingleOrDefault(t => t.Email == user.Email);
        var res = bdUser != null && bdUser.Password == user.Password;
        return res;
    }

    public Models.User GetUser(string email)
    {
        return _context.Users.SingleOrDefault(e => e.Email == email);
    }
}
