using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class LocalizationResourceManager : ILocalizationResourceService
    {
        private readonly IUnitOfWork _uow;

        public LocalizationResourceManager(IUnitOfWork uow)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(uow));
        }

        public async Task<List<LocalizationResource>> GetAll()
        {
            var data = await _uow.GetRepository<LocalizationResource>().GetAllByFilterAsync(x => x.Active);
            return data.ToList();
        }

        public async Task<LocalizationResource> GetByLanguage(string key, int language)
        {
            var data = await _uow.GetRepository<LocalizationResource>().GetByFilterAsync(x => x.Key == key && x.Language == language && x.Active);
            return data;

        }
    }
}
