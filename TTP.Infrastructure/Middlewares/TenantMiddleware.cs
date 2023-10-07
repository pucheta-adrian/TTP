using Microsoft.AspNetCore.Http;
using TTP.Common;

namespace TTP.Infrastructure.Middlewares;

public class TenantMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if(context.Request.RouteValues.TryGetValue(Constants.Tenant, out var tenant))
            context.Items.Add(Constants.Tenant, tenant);

        await next(context);
        return;
    }
}