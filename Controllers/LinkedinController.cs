using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Linkedin.App.Controllers
{
    [Route("api/[controller]")]
    public class LinkedinController : Controller
    {
        [Route("api/[controller]/linkedin"), HttpGet]
        public RedirectResult LinkedIn()
        {
            //using (var httpClient = new HttpClient())
            //{

            var address = $"https://www.linkedin.com/oauth/v2/authorization?response_type=code&client_id=81gloj7clvbhay&redirect_uri=http://localhost:52970/api/home/callback&state=Technossus@1&scope=r_fullprofile%20r_emailaddress%20w_share";
            return Redirect(address);
            //return Ok("Result would come here");
            // }

        }

        [Route("api/[controller]/callback"), HttpGet]
        public IActionResult CallBack(string code, string error)
        {

            return Ok($"Code is {code}");
        }
    }
}
