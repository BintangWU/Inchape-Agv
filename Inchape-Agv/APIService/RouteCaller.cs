using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using APIService.Model;
using Inchape_Agv.APIService;
using System.Windows.Markup.Localizer;
using System.Diagnostics;
using System.Security.Permissions;
using System.Data;

namespace APIService
{
    [ApiController]
    [Route("[controller]")]
    [Tags("Caller")]
    public class RouteCaller : BaseResponse
    {
        [HttpGet("/status")]
        public IActionResult GetStatusCar()
        {
            var imNow = new
            {
                status = "online",
                timstamp = DateTime.UtcNow
            };
            return OkResponse("sucess", imNow);
        }

        [HttpGet("/statusStock")]
        public IActionResult GetStockData()
        {
            return Ok("Under Mintenance");
        }

        [HttpPost("/callCar")]
        public IActionResult CallCar([FromBody] Request data) 
        {
            int type = data.type;
            string message = "";

            switch (type)
            {
                case 0:
                    try
                    {
                        DataTable dt = DbServices.DbServices.Instance.DB_InOutbound.InboudStock(data.prodNo.ToString());
                        bool flag = dt != null && dt.Rows.Count == 2;
                        if (flag)
                        {
                            message = "success";
                            Debug.WriteLine("Inbound Stock Success");
                        }
                    }
                    catch (Exception ex )
                    {
                        message = ex.Message;
                    }
                    break;

                case 1:
                    Debug.WriteLine("Calling Outbound");
                    break;

                default: break;
            }

            return OkResponse(message, new { type = type, prodNo = data.prodNo });
        }

        
    }
}
