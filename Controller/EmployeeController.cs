using Microsoft.AspNetCore.Mvc;

namespace Microservice_Demo.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        public EmployeeController()
        {

        }

        [HttpGet]
        [Route("Message")]
        public ActionResult Get()
        {
            string message = GetMessage();
            return Ok(message);
        }

        private static string GetMessage()
        {
            return "API Hit Successfully!";
        }
    }
}
