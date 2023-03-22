//using Microsoft.AspNetCore.Components.Authorization;
//using System.Security.Claims;

//namespace BlazorFront
//{
//    internal class TokenAuthenticationStateProvider : AuthenticationStateProvider
//    {
//        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
//        {
//            var anonymousIdentity = new ClaimsIdentity();
//            var anonymousPrincipal = new ClaimsPrincipal(anonymousIdentity);
//            return new AuthenticationState(anonymousPrincipal);
//        }
//    }
//}