using System.ComponentModel.DataAnnotations;

namespace ExceptionMiddleware.Exception;

public static class ApiException
{
    public enum ExceptionMessages
    {
        [Display(Name = "AuthorizationsDenied", Order = 403)]
        AuthorizationsDenied = 9997,
    }
}