
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Finance.Services;

    public class DataManagementService
    {
      public readonly IConfiguration _configuration;
   
    public MongoService mongoService;
    public UserManager<ApplicationUser> _UserManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private object userService;

    public DataManagementService(IConfiguration configuration, AuthenticationStateProvider AuthenticationStateProvider, UserManager<ApplicationUser> UserManager ,IHttpContextAccessor httpContextAccessor)
    {
        mongoService = new MongoService(configuration.GetConnectionString("MongoDB"), configuration.GetSection("Databases").GetSection("MongoDB")["DbName"],
            configuration.GetSection("Databases").GetSection("MongoDB")["FinanceCollection"]);
        _UserManager = UserManager;
        _httpContextAccessor = httpContextAccessor;
    }

    public string getUserId()
    {
        string userId = string.Empty;
        if (_httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated == true)
        {
             userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            string userEmail = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
        }
        return userId;
    }

    public string getUserEmail()
    {
        string userEmail = string.Empty;
        if (_httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated == true)
        {
            userEmail = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
        }
        return userEmail;
    }
}



    

