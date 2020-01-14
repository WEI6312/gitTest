using System.Net.Http;


namespace EMS.Services
{
    public interface IUserService
    {
        HttpResponseMessage login(string account, string password);
        HttpResponseMessage getUserInfo(int id);
    }
}