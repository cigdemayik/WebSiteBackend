using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.AboutUsDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class AboutUsManager : IAboutUsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public AboutUsManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }

        public async Task<ServiceResponse<List<AboutUsDto>>> GetAll()
        {
            try
            {
                var data = await _unitOfWork.GetRepository<AboutUs>().GetAllByFilterAsync();
                var mappedData = data.ToList().Adapt<List<AboutUsDto>>();
                if (mappedData != null)
                    return _serviceResponseHelper.SetSuccess<List<AboutUsDto>>(mappedData, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<AboutUsDto>>(null, "Hiç Hakkımızda kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<AboutUsDto>>(null, "Hakkımızda kayıtları getirilirken sorunla karşılaşıldı sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<AboutUsDto>> GetAllByLanguage(LanguageEnum language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<AboutUs>().GetByFilterAsync(x => x.Language == language);
                var dto = data.Adapt<AboutUsDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<AboutUsDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<AboutUsDto>(null, "Hiç Hakkımızda kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<AboutUsDto>(null, "Hakkımızda kayıtları getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<AboutUsDto>> GetById(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<AboutUs>().GetByFilterAsync(x => x.Id == id);
                var dto = data.Adapt<AboutUsDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<AboutUsDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<AboutUsDto>(null, "Hakkımızda kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<AboutUsDto>(null, "Hakkımızda kaydı getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<bool>> Update(AboutUsUpdateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<AboutUs>();
                var data = await _unitOfWork.GetRepository<AboutUs>().UpdateAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (data)
                    return _serviceResponseHelper.SetSuccess<bool>(data, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(data, "Hakkımızda güncelleme işlemi yapılamadı", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Hakkımızda güncellenirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
