using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using APIService.Model;
using Inchape_Agv.APIService;

namespace APIService
{
    [ApiController]
    [Route("[controller]")]
    [Tags("Caller")]
    public class RouteCaller : BaseResponse
    {
        [HttpGet("/Status")]
        public IActionResult Get()
        {
            var imNow = new
            {
                status = "online",
                timstamp = DateTime.UtcNow
            };
            return OkResponse("sucess", imNow);
        }

        [HttpPost("/Calling")]
        public IActionResult Post([FromBody] Request data) 
        {
            return Ok(new {recieve = data});
        }
    }
}
