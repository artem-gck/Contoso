using Contoso.Service.Models;
using System.Net.Http.Headers;

namespace Contoso.Service.Logic
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
            => _httpClient = httpClient;

        public Task Login(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }
    }
}
