using BlazorFront.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorFront.Services
{
    public class StateService
    {
        public bool IsLogin { get; private set; } = false;
        public User? User { get; private set; } = null;

        public event Action<ComponentBase, bool>? IsLoginChanged;

        public bool LogInChange(ComponentBase sender)
        {
            IsLogin = !IsLogin;
            NotifyIsLoginChanged(sender, IsLogin);
            return IsLogin;
        }

        private void NotifyIsLoginChanged(ComponentBase sender, bool isLogin)
        {
            IsLoginChanged?.Invoke(sender, isLogin);
        }

        public void SetUser(User user)
        {
            User = user;
        }
    }
}
