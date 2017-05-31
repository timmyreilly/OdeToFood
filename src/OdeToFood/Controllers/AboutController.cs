using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("[action]")]
        public string Phone()
        {
            return "555-555-5555";
        }

        [Route("address")]
        public string Address()
        {
            return "usa"; 
        }
    }
}
