namespace APIService.Model
{
    class API_Response
    {
        public bool status { get; set; }
        public string message { get; set; }
        public object data { get; set; }

        public API_Response(bool status, string message, object data)
        {
            this.status = status;
            this.message = message;
            this.data = data;
        }

        public static API_Response GenResponse(bool status = false, string message = "", object data = null)
        {
            return new API_Response(status, message, data);
        }
    }
}
