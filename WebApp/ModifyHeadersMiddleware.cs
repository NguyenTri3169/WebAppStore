using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace WebApp
{
    public class ModifyHeadersMiddleware
    {
        private readonly RequestDelegate _next;

        public ModifyHeadersMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Thêm hoặc cập nhật header 'X-Modified-By'
            context.Request.Headers["hacker"] = "MR QUÂN";

            // Tiếp tục xử lý request
            await _next(context);
        }
    }
}
