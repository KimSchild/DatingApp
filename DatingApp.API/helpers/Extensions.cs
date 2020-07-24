using Microsoft.AspNetCore.Http;

namespace DatingApp.API.helpers
{
    public static class Extensions //we dont need to use an instance of this class to use one of its methods
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Applicatoin-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-control-Allow-Origin", "*");
        }
    }
}