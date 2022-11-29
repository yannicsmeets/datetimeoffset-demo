using Microsoft.AspNetCore.Mvc;

namespace DateTimeOffsetDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public DateTimeOffset Post([FromForm] InputModel model)
        {
            return model.StartDate;
        }
    }

    public class InputModel
    {
        public DateTimeOffset StartDate { get; set; }
    }
}