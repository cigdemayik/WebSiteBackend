using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;

namespace WebSiteBackend.Helpers.ServiceHelpers.Concrete
{
    public class ServiceResponseHelper : IServiceResponseHelper
    {
        public ServiceResponse SetError(string errorMessage, int statusCode = 500)
        {
            return new ServiceResponse(errorMessage,false);
        }

        public ServiceResponse<T> SetError<T>(T data, string errorMessage, int statusCode = 500)
        {
            return new ServiceResponse<T>(data,errorMessage, false);
        }

        public ServiceResponse SetSuccess()
        {
            return new ServiceResponse(null, true);
        }

        public ServiceResponse<T> SetSuccess<T>(T data)
        {
            return new ServiceResponse<T>(data,null,true);
        }
    }
}
