using Autofac.Extras.DynamicProxy;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Aspect;
using WebSiteBackend.Business.Dtos.MissionDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class MissionManager : IMissionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;


        public MissionManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }
        public async Task<ServiceResponse<bool>> ChangeStatus(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Mission>().GetByFilterAsync(x => x.Id == id);
                data.Active = !data.Active;
                await _unitOfWork.SaveChangesAsync();
                return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Misyon durumu değiştiriliyorken sorunla karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<bool>> Delete(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Mission>().GetByFilterAsync(x => x.Id == id, null, Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking);
                var operation = await _unitOfWork.GetRepository<Mission>().DeleteAsync(data);
                await _unitOfWork.SaveChangesAsync();
                if (operation)
                    return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(false, "Misyon silinemedi", System.Net.HttpStatusCode.BadRequest);

            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Misyon silinirken bir hata ile karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<List<MissionDto>>> GetAll()
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Mission>().GetAllByFilterAsync();
                var mappedData = data.ToList().Adapt<List<MissionDto>>();
                if (mappedData != null)
                    return _serviceResponseHelper.SetSuccess<List<MissionDto>>(mappedData, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<MissionDto>>(null, "Hiç Misyon kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<MissionDto>>(null, "Misyon kayıtları getirilirken sorunla karşılaşıldı sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }
        public async Task<ServiceResponse<List<MissionDto>>> GetAllByLanguage(int language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Mission>().GetAllByFilterAsync(x => x.Language == (int)language);
                var dto = data.ToList().Adapt<List<MissionDto>>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<List<MissionDto>>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<MissionDto>>(null, "Hiç Misyon kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<MissionDto>>(null, "Misyon kayıtları getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<MissionDto>> GetById(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Mission>().GetByFilterAsync(x => x.Id == id);
                var dto = data.Adapt<MissionDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<MissionDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<MissionDto>(null, "Misyon kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<MissionDto>(null, "Misyon kaydı getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }

        }

        public async Task<ServiceResponse<MissionDto>> GetByLanguage(int language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Mission>().GetByFilterAsync(x => (int)x.Language == language);
                var mappedData = data.Adapt<MissionDto>();
                if (mappedData != null)
                {
                    return _serviceResponseHelper.SetSuccess<MissionDto>(mappedData, System.Net.HttpStatusCode.OK);
                }
                return _serviceResponseHelper.SetError<MissionDto>(null, "Misyon Bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<MissionDto>(null, "Misyon Getirilirken Bir Sorun ile Karşılaşıldı", System.Net.HttpStatusCode.BadRequest);
            }
        }

        public async Task<ServiceResponse<bool>> Update(MissionUpdateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<Mission>();
                var data = await _unitOfWork.GetRepository<Mission>().UpdateAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (data)
                    return _serviceResponseHelper.SetSuccess<bool>(data, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(data, "Misyon güncelleme işlemi yapılamadı", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Misyon güncellenirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
