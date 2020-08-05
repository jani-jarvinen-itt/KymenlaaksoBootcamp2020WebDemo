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
        public int Luku()
        {
            return 123;
        }
    }
}
