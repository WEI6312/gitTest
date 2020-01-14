using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMS.Models;
using EMS.tool;

namespace EMS.Repository
{
    public class UserDAL : IUserDAL
    {
        public User login(string account, string password)
        {
           User user = DB.Context.From<User>()
            .Where(d => (d.Account == account && d.Password == password))
            .ToFirst();
            if (user == null) return null;
            user.Attach();
            user.ExpiryTime = DateTime.Now.AddHours(1);
            CreateToken tokenGeneral = new CreateToken();
            string token = tokenGeneral.create(user.Id, user.ExpiryTime);
            user.Token = token;
            DB.Context.Update<User>(user);
            return user;
        }

        public string getToken()
        {
            return null;
        }

        public User getUserInfo(int id)
        {
            User user = DB.Context.From<User>()
             .Where(d => (d.Id == id))
             .ToFirst();

            if (user == null) return null;

            return user;
        }
    }
}