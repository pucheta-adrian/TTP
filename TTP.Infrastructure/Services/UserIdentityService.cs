using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using TTP.Application.Services.Interfaces;

namespace TTP.Infrastructure.Services;

public class UserIdentityService : IUserIdentityService
{

    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserIdentityService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public long UserId()
    {
        var userIdClaim = _httpContextAccessor.HttpContext!.User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim != null && long.TryParse(userIdClaim.Value, out var userId))
        {
            return userId;
        }
        
        throw new InvalidOperationException("No se pudo obtener el UserId.");
    }

    public string[] Tenants()
    {
        var localityClaim = _httpContextAccessor.HttpContext!.User.FindFirst(ClaimTypes.Locality);
        if (localityClaim != null)
        {
            return localityClaim.Value.Split(';');
        }

        throw new InvalidOperationException("No se pudo obtener el UserId.");
    }
}