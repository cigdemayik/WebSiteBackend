using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Helpers.ServiceHelpers.Concrete
{
    public class ServiceResponse<TResult> : ServiceResponse
    {
        public ServiceResponse(TResult result, bool isSuccessful = true)
        {
            Result = result;
            IsSuccessful = isSuccessful;
        }
        public ServiceResponse(TResult result, string errorMessage, bool isSuccessful = false)
        {
            Result = result;
            IsSuccessful = isSuccessful;
            ErrorMessage = errorMessage;
        }
        public TResult Result { get; set; }
    }
}
