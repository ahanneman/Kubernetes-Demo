using Microsoft.AspNetCore.Mvc;

namespace Kubernetes.TestApp.Controllers
{
    [Route("api/")]
    public class ValuesController : Controller
    {
        [HttpGet("")]
        public string Get(int id)
        {
            return "System is up and running";
        }

        [HttpGet("MachineName")]
        public string GetMachineName(int id)
        {
            return System.Environment.MachineName;
        }
    }
}
