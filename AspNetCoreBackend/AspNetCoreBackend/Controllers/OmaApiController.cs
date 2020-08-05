using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBackend.Controllers
{
    [Route("api/oma")]
    [ApiController]
    public class OmaApiController : ControllerBase
    {
        [Route("luku")]
        public int Luku()
        {
            return 123;
        }

        [Route("merkkijono")]
        public string Merkkijono()
        {
            return "ABCD";
        }

        [Route("merkkijonot")]
        public string[] Merkkijonot()
        {
            return new string[] { "ABCD", "DEFG" };
        }
    }
}
