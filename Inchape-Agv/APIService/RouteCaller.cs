using APIService.Model;
using DbServices.Models;
using Inchape_Agv.APIService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace APIService
{
    [ApiController]
    [Route("[controller]")]
    [Tags("Caller")]
    public class RouteCaller : BaseResponse
    {
        private static readonly SemaphoreSlim _lock = new SemaphoreSlim(1,1);
        //private static readonly ConcurrentDictionary<string, SemaphoreSlim> _lock = new ConcurrentDictionary<string, SemaphoreSlim>();

        [HttpGet("/status")]
        public async Task<IActionResult> GetStatusCar()
        {
            await _lock.WaitAsync();
            try
            {

            }
            //catch { }
            finally
            {
                _lock.Release();
            }

            return Ok(new API_Response(true, "Success", new
            {
                status = "online",
                timstamp = DateTime.UtcNow
            }));
        }

        [HttpGet("/statusStock")]
        public async Task<IActionResult> GetStockData()
        {
            await _lock.WaitAsync();
            try
            {
                return Ok("Under Mintenance");
            }
            //catch { }
            finally
            {
                _lock.Release();
            }
        }

        [HttpPost("/callCar")]
        public async Task<IActionResult> CallCar([FromBody] CallModel data) 
        {
            await _lock.WaitAsync();
            string code = "";
            string destination = "";
            string message = "";
            bool status = false;
            int[] routes;

            DataTable dt = null;
            DBM_TaskOrder taskOrder = null;
            DBM_TaskOrder model = null;

            try
            {
                switch (data.type)
                {
                    case 0: //Inbound Calling
                        {
                            code = data.prodNo.ToString();
                            dt = DbServices.DbServices.Instance.DB_InOutbound.InboudStock(code);
                            destination = dt.Rows[0]["name"].ToString();

                            bool flag = dt != null && dt.Rows.Count == 2;
                            if (flag)
                            {
                                message = $"Success, Inbound Stock [{code}, {destination}]";
                                status = true;
                            }
                            break;
                        }

                    case 1: //Outbound Calling
                        {
                            code = data.prodNo.ToString();
                            dt = DbServices.DbServices.Instance.DB_InOutbound.Outbound(code);
                            destination = dt.Rows[0]["name"].ToString();

                            bool flag = dt != null && dt.Rows.Count == 2;
                            if (flag)
                            {
                                message = $"Success, Outbound Stock [{code}]";
                                status = true;
                            }
                            break;
                        }

                    default: break;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                status = false;
            }
            finally
            {
                _lock.Release();
            }

            return Ok(new API_Response(status, message, new
            {
                call = data?.type ?? 0,
                stock = destination.ToString(),
                prodNo = data?.prodNo?.ToString() ?? ""
            }));
        }
    }
}
