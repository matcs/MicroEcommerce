using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Enums
{
    public enum HttpStatus
    {
        //Successful responses
        Ok = 200,
        Created = 201,
        Accepted = 202,
        NoContent = 204,

        //Client error responses
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405

    }
}
