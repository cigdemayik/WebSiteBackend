using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Helpers.ServiceHelpers.Abstract
{
    public interface IServiceResponseHelper
    {
        ServiceResponse SetError(string errorMessage, int statusCode = 500);
        ServiceResponse<T> SetError<T>(T data,string errorMessage, int statusCode = 500);
        ServiceResponse SetSuccess();
        ServiceResponse<T> SetSuccess<T>(T data);
    }
}
