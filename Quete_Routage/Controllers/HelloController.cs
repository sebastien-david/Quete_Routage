using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quete_Routage.Controllers
{
    public class HelloController : Controller
    {
        public String SayHello()
        {
            return "Hello !";
        }

        public String YellHello()
        {
            return "HELLO !";
        }

        [Route("/Say")] // The endpoint here is reached by calling `/Say` route
        public String SayHelloAttribut()
        {
            return "Hello !";
        }

        [Route("/Yell")] // The endpoint here is reached by calling `/Yell` route
        public String YellHelloAttribut()
        {
            return "HELLO !";
        }
    }
}
