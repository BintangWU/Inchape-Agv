using APIService.Model;
using Microsoft.AspNetCore.Mvc;

namespace Inchape_Agv.APIService
{
    public class BaseResponse : ControllerBase
    {
        protected IActionResult OkResponse(string message = "", object data = null)
        {
            return base.Ok(global::APIService.Model.Response.GenResponse(true, message, data));
        }

        protected IActionResult ErrResponse(string message = "error", object data = null)
        {
            return base.BadRequest(global::APIService.Model.Response.GenResponse(false, message, data));
        }
    }
}
