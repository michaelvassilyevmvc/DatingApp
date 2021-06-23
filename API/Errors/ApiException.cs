namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCod, string message = null, string details = null)
        {
            StatusCod = statusCod;
            Message = message;
            Details = details;
        }

        public int StatusCod { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        

    }
}