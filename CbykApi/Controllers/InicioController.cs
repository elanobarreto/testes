using System.Collections.Generic;
using System.Threading.Tasks;
using Cbyk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cbyk.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class InicioController : ControllerBase {
       
        public InicioController() {
        }

        [HttpGet]
        public string Get1 () {
            return "hello docker!";
        }

    }
}