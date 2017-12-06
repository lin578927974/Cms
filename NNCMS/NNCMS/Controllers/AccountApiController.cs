using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace NNCMS.Controllers
{
    [Route("user")]
    [Authorize]
    public class AccountApiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return new JsonResult(new string[] { "value1", "value2" });
        }
    }
}