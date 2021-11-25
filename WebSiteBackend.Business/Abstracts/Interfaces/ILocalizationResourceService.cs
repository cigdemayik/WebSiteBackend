using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface ILocalizationResourceService
    {
        Task<List<LocalizationResource>> GetAll();
        Task<LocalizationResource> GetByLanguage(string key,int language);
    }
}
