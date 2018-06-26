using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_withTokenProject.Controllers
{
    [RoutePrefix("info")]
    public class InfoController : ApiController
    {
        [Route("")]
        public IHttpActionResult Get()
        {
            var info = "Token Based Authentication using ASP.NET Web API 2, Owin, and Identity: http://bitoftech.net/2014/06/01/token-based-authentication-asp-net-web-api-2-owin-asp-net-identity/"; 
            return Ok(info);
        }


    }
}
