using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using EMS.Services;
using EMS.tool;
using EMS.Models;
using System.Text;
using Newtonsoft.Json;

namespace EMS.Controllers
{
    public class UserController : ApiController
    {
        private IUserService userService = ServiceContainer.Resolve<IUserService>();

        [HttpGet]
        public HttpResponseMessage login(string account, string password)
        {
            return userService.login(account, password); ;
        }

        [HttpGet]
        public HttpResponseMessage getUserInfo(int id)
        {
            return userService.getUserInfo(id);
        }
    }
}
