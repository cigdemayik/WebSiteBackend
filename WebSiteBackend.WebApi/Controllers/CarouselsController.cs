using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselsController:ControllerBase
    {
        private readonly ICarouselService _carouselService;

        public static IWebHostEnvironment _environment;

        public CarouselsController(ICarouselService carouselService, IWebHostEnvironment environment)
        {
            _carouselService = carouselService;
            _environment = environment;
        }

       
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response=_carouselService.GetById(id);
            return Ok();
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Create([FromForm] Carousel entity)
        {
            if (entity.Image.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\carousels\\"))
                    {
                        var directory = Directory.CreateDirectory(_environment.WebRootPath + "\\carousels\\");
                       
                        
                    }
                    var fileName = DateTime.Now.ToLongDateString() + "_" + entity.Image.FileName;
                    var path = Path.Combine(_environment.WebRootPath , "carousels/" + fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await entity.Image.CopyToAsync(stream);
                    }
                    entity.ImageUrl = path;
                    var response = _carouselService.Create(entity);
                    if (response.IsSuccessful == true)
                    {
                        return Created("", response.Result);
                    }
                    else
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            return NotFound(response.ErrorMessage);
                        }
                        return BadRequest(response.ErrorMessage);
                    }

                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }
            }
            return BadRequest("Seçili Bir Dosya Yok İşlem Gerçekleştirilemez!!");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _carouselService.GetAll();
            if (response.IsSuccessful == true)
            {
                return Ok(response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        [HttpPut]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Update([FromForm]Carousel entity)
        {
            if (entity.Image!=null && entity.Image.Length > 0)
            {
                
                var fileName = DateTime.Now.ToLongDateString() + "_" + entity.Image.FileName;
                var path = Path.Combine(_environment.WebRootPath, "carousels/" + fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await entity.Image.CopyToAsync(stream);
                }
                entity.ImageUrl = path;
                var response = _carouselService.Update(entity);
                if (response.IsSuccessful == true)
                {
                    return NoContent();
                }
                else
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        return NotFound(response.ErrorMessage);
                    }
                    return BadRequest(response.ErrorMessage);
                }
            }
            else
            {
                entity.UpdateTime = DateTime.Now;
                entity.ImageUrl = _carouselService.GetByIdAsNoTracking(entity.Id).Result.ImageUrl;
                var response = _carouselService.Update(entity);
                if (response.IsSuccessful == true)
                {
                    return NoContent();
                }
                else
                {
                    return BadRequest(response.ErrorMessage);
                }
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = _carouselService.Delete(id);
            if (response.IsSuccessful == true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }
    }
}
