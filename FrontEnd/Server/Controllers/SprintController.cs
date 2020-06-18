using FrontEnd.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrontEnd.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SprintController : Controller
    {

        private readonly ILogger<SprintController> logger;

        public SprintController(ILogger<SprintController> logger)
        {
            this.logger = logger;
        }

  //      [HttpGet]
  //      public SprintTester Get()
  //      {
   //         SprintTester test = new SprintTester();
//
   //         test.value = "test.value";
   //         test.start = "test.start";
   //         test.end = "test.end";
//
   //         return test;
            //
            //
 //       }

        [HttpGet]
        public SprintTester Get()
        {

            SprintTester test = new SprintTester();
            
                     test.value = "test.value";
                     test.start = "test.start";
                     test.end = "test.end";
            
                     return test;

            // return Enumerable.Range(1,2).Select(index => new SprintTester
            // {
            //    value = "test.value",
            //    start = "test.start",
            //    end = "test.end",
            //     }
            //     ).ToArray();


        }
    }
}
