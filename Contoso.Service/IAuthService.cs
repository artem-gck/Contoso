using Contoso.Services.Models;

namespace Contoso.Services
{
    public interface IAuthService
    {
        public Task Login(LoginModel loginModel);
    }
}
