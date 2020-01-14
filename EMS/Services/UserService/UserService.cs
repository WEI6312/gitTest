using EMS.Models;
using EMS.Repository;
using EMS.tool;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;

namespace EMS.Services
{
    public class UserService : IUserService
    {
        private IUserDAL userDal= DALContainer.Resolve<IUserDAL>();

        public HttpResponseMessage login(string account, string password)
        {
            User user = userDal.login(account, password);
            HttpResponseMessage h = new HttpResponseMessage();
            if (user == null ) h.Content = new StringContent(JsonConvert.SerializeObject(new { stasus = 0, message = "用户名或密码错误" }), Encoding.GetEncoding("UTF-8"), "application/json");
            else
            {
                h.Content = new StringContent(JsonConvert.SerializeObject(new { stasus = 1, user }), Encoding.GetEncoding("UTF-8"), "application/json");
            }
            return h;
        }

        public HttpResponseMessage getUserInfo(int id)
        {
            User user = userDal.getUserInfo(id);
            HttpResponseMessage h = new HttpResponseMessage();
            if (user == null) h.Content = new StringContent(JsonConvert.SerializeObject(new { stasus = 0, message = "用户信息错误" }), Encoding.GetEncoding("UTF-8"), "application/json");
            else
            {
                h.Content = new StringContent(JsonConvert.SerializeObject(new { stasus = 1, user }), Encoding.GetEncoding("UTF-8"), "application/json");
            }
            return h;
        }
    }
}