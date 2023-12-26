namespace BokingManagementApp.Utilities.Response
{
    public class ResponseHandler<Tentity>
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }

        public Tentity? Data { get; set; }
    }
}
