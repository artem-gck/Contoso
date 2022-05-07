using Contoso.Service.Models;

namespace Contoso.Service
{
    public interface IAuthService
    {
        public Task Login(LoginModel loginModel);
    }
}
