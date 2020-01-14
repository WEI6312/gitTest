using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace EMS.Controllers
{
    public class HomeController : ApiController
    {
        [System.Web.Http.HttpGet]
        public OkResult Index() => Ok();
    }
}
