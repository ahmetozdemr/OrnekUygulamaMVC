using Microsoft.AspNetCore.Http;

namespace OrnekUygulamaMVC.Handlers
{
    public class ExampleHandler
    {
        public RequestDelegate Handler()
        {
            return async c =>
            {
                await c.Response.WriteAsync("hello world");
            };
        }
    }
}
