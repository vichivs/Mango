namespace Mango.Web.Utility
{
    public class SD
    {
        public static string CouponAPIBase { get; set; }

        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public static class StatusMessages
        {
            public const string NotFound = "Not Found";
            public const string AccessDenied = "Access Denied!";
            public const string Unauthorized = "Unauthorized";
            public const string InternalServerError = "Internal Server Error";
        }
    }
}
