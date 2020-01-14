using EMS.Models;
using EMS.Repository;
using EMS.tool;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
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
                System.Web.HttpContext.Current.Response.Cookies.Add(new HttpCookie("token")
                {
                    Value = user.Token,
                    Expires = user.Entry_time
                });
                const string secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";
                byte[] key = Encoding.UTF8.GetBytes(secret);
                IJsonSerializer serializer = new JsonNetSerializer();
                IDateTimeProvider provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);
                //解密
                var json = decoder.DecodeToObject<Models.Auth>(user.Token, key, verify: true);
                h.Content = new StringContent(JsonConvert.SerializeObject(new { json, stasus = 1, user }), Encoding.GetEncoding("UTF-8"), "application/json");
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