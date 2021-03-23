using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Helpers.ServiceHelpers.Concrete
{
    public class ServiceResponse
    {
        public ServiceResponse(bool isSuccessful=true)
        {
            IsSuccessful = isSuccessful;
        }
        public ServiceResponse(string errorMessage, bool isSuccessful = true)
        { 
            ErrorMessage = errorMessage;IsSuccessful = isSuccessful; 
        }
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
    }
}
