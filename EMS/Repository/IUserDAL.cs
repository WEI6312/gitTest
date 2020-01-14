using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.Repository
{
    public interface IUserDAL
    {
        User login(string account, string password);
        string getToken();
        User getUserInfo(int id);
    }
}