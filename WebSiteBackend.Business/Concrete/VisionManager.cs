using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Aspect;
using WebSiteBackend.Business.Dtos.VisionDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    [BusinessAspect]
    public class VisionManager : IVisionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public VisionManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }
        public async Task<ServiceResponse<bool>> ChangeStatus(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Vision>().GetByFilterAsync(x => x.Id == id);
                data.Active = !data.Active;
                await _unitOfWork.SaveChangesAsync();
                return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Vizyon durumu değiştiriliyorken sorunla karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<bool>> Delete(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Vision>().GetByFilterAsync(x => x.Id == id, null, Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking);
                var operation = await _unitOfWork.GetRepository<Vision>().DeleteAsync(data);
                await _unitOfWork.SaveChangesAsync();
                if (operation)
                    return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(false, "Vizyon silinemedi", System.Net.HttpStatusCode.BadRequest);

            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Vizyon silinirken bir hata ile karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
    }

    public async Task<ServiceResponse<List<VisionDto>>> GetAll()
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Vision>().GetAllByFilterAsync();
                var mappedData = data.ToList().Adapt<List<VisionDto>>();
                if (mappedData != null)
                    return _serviceResponseHelper.SetSuccess<List<VisionDto>>(mappedData, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<VisionDto>>(null, "Hiç Vizyon kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<VisionDto>>(null, "Vizyon kayıtları getirilirken sorunla karşılaşıldı sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }
        public async Task<ServiceResponse<List<VisionDto>>> GetAllByLanguage(int language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Vision>().GetAllByFilterAsync(x => x.Language == (int)language);
                var dto = data.ToList().Adapt<List<VisionDto>>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<List<VisionDto>>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<VisionDto>>(null, "Hiç Vizyon kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<VisionDto>>(null, "Vizyon kayıtları getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<VisionDto>> GetById(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Vision>().GetByFilterAsync(x => x.Id == id);
                var dto = data.Adapt<VisionDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<VisionDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<VisionDto>(null, "Vizyon kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<VisionDto>(null, "Vizyon kaydı getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<VisionDto>> GetByLanguage(int language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Vision>().GetByFilterAsync(x => (int)x.Language == language);
                var mappedData = data.Adapt<VisionDto>();
                if (mappedData != null)
                {
                    return _serviceResponseHelper.SetSuccess<VisionDto>(mappedData, System.Net.HttpStatusCode.OK);
                }
                return _serviceResponseHelper.SetError<VisionDto>(null, "Vizyon Bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<VisionDto>(null, "Vizyon Getirilirken Bir Sorun ile Karşılaşıldı", System.Net.HttpStatusCode.BadRequest);
            }
        }

        public async Task<ServiceResponse<bool>> Update(VisionUpdateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<Vision>();
                var data = await _unitOfWork.GetRepository<Vision>().UpdateAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (data)
                    return _serviceResponseHelper.SetSuccess<bool>(data, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(data, "Vizyon güncelleme işlemi yapılamadı", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Vizyon güncellenirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }

        
}

