using System;
using Mapster;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.VissionMissionDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class VissionMissionManager : IVissionMissionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public VissionMissionManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }

        public async Task<ServiceResponse<List<VissionMissionDto>>> GetAll()
        {
            try
            {
                var data = await _unitOfWork.GetRepository<VisionMission>().GetAllByFilterAsync();
                var mappedData = data.ToList().Adapt<List<VissionMissionDto>>();
                if (mappedData != null)
                    return _serviceResponseHelper.SetSuccess<List<VissionMissionDto>>(mappedData, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<VissionMissionDto>>(null, "Hiç Hakkımızda kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<VissionMissionDto>>(null, "Hakkımızda kayıtları getirilirken sorunla karşılaşıldı sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<VissionMissionDto>> GetAllByLanguage(LanguageEnum language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<VisionMission>().GetByFilterAsync(x => x.Language == language);
                var dto = data.Adapt<VissionMissionDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<VissionMissionDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<VissionMissionDto>(null, "Hiç Hakkımızda kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<VissionMissionDto>(null, "Hakkımızda kayıtları getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<VissionMissionDto>> GetById(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<VisionMission>().GetByFilterAsync(x => x.Id == id);
                var dto = data.Adapt<VissionMissionDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<VissionMissionDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<VissionMissionDto>(null, "Hakkımızda kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<VissionMissionDto>(null, "Hakkımızda kaydı getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<bool>> Update(VissionMissionUpdateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<VisionMission>();
                var data = await _unitOfWork.GetRepository<VisionMission>().UpdateAsync(mappedData);
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
