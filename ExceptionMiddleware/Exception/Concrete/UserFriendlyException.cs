using System.Net;

namespace ExceptionMiddleware.Exception.Concrete;

public class UserFriendlyException : CustomException
{
    public Enum ExceptionTypeEnum { get; set; }
    
    public UserFriendlyException(Enum exceptionTypeEnum, List<string>? errors = default,
        HttpStatusCode statusCode = HttpStatusCode.NoContent) : base("Failures Occured.", errors, statusCode)
    {
        ExceptionTypeEnum = exceptionTypeEnum;
    }
}