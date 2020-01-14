using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using JWT;
using JWT.Serializers;
using EMS.Models;
using System.Text;
using System.Net;
using System.Net.Http;

namespace EMS.tool
{
    /// <summary>
    /// 身份认证拦截器
    /// </summary>
    public class ApiAuthorizeAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 指示指定的控件是否已获得授权
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            //前端请求api时会将token存放在名为"auth"的请求头中
            var authHeader = from t in actionContext.Request.Headers where t.Key == "auth" select t.Value.FirstOrDefault();
            //前端请求api时会将id存放在名为"user"的请求头中
            var idHeader = from t in actionContext.Request.Headers where t.Key == "user" select t.Value.FirstOrDefault();
            if (authHeader != null && idHeader != null)
            {
                const string secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";//加密秘钥
                string token = authHeader.FirstOrDefault();//获取token
                int id;
                int.TryParse(idHeader.FirstOrDefault(),out id);//获取token
                if (!string.IsNullOrEmpty(token)&& id>0)
                {
                    try
                    {
                        byte[] key = Encoding.UTF8.GetBytes(secret);
                        IJsonSerializer serializer = new JsonNetSerializer();
                        IDateTimeProvider provider = new UtcDateTimeProvider();
                        IJwtValidator validator = new JwtValidator(serializer, provider);
                        IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                        IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);
                        //解密
                        var json = decoder.DecodeToObject<Auth>(token, key, verify: true);
                        if (json != null)
                        {
                            //判断口令过期时间
                            if (json.ExpiryTime < DateTime.Now)
                            {
                                return false;
                            }
                            if (json.Id != id)
                            {
                                return false;
                            }
                            actionContext.RequestContext.RouteData.Values.Add("auth", json);
                            return true;
                        }
                        return false;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        return false;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 处理授权失败的请求
        /// </summary>
        /// <param name="actionContext"></param>
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var erModel = new
            {
                Success = "false",
                ErrorCode = "401"
            };
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, erModel, "application/json");
        }

        /// <summary>
        ///  为操作授权时调用
        /// </summary>
        /// <param name="actionContext"></param>
        //public override void OnAuthorization(HttpActionContext actionContext)
        //{

        //}
    }
}