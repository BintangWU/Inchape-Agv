using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIService.Model
{
    class Response
    {
        public bool status { get; set; }
        public string message { get; set; }
        public object data { get; set; }

        public Response(bool status, string message, object data)
        {
            this.status = status;
            this.message = message;
            this.data = data;
        }

        public static Response GenResponse(bool status = false, string message = "", object data = null)
        {
            return new Response(status, message, data);
        }
    }
}
