using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.BlogDtos;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController: ControllerBase

    {
        private readonly IBlogService _blogService;

        public static IWebHostEnvironment _environment;

        public BlogsController(IBlogService blogService,IWebHostEnvironment environment)
        {
            _blogService = blogService;
            _environment = environment;

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response = _blogService.GetById(id);

            return Ok();

        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Create([FromForm] BlogCreateDto dto)
        {
            if (dto.Image.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\blogs\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\blogs\\");
                    }
                    var fileName = DateTime.Now.ToLongDateString()+"_" + dto.Image.FileName;
                    var path = Path.Combine(_environment.WebRootPath, "blogs/" + fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await dto.Image.CopyToAsync(stream);
                    }
                    dto.ImageUrl = path;
                    var response = await _blogService.Create(dto);
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
                catch (Exception ex )
                {

                    return BadRequest(ex.Message);
                }
            }
                return BadRequest("Seçili bir dosya yok işlem yapılamaz");


        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {

            var response = await _blogService.GetAllByLanguage(Helpers.Enums.LanguageEnum.Türkçe);
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
        public async Task<IActionResult> Update([FromForm]BlogUpdateDto dto)
        {
            if(dto.Image!=null && dto.Image.Length > 0)
            {
                var fileName = DateTime.Now.ToLongDateString() + "_" + dto.Image.FileName;
                var path = Path.Combine(_environment.WebRootPath, "blogs/" + fileName);

                using(var stream= new FileStream(path, FileMode.Create))
                {
                    await dto.Image.CopyToAsync(stream);
                }
                dto.ImageUrl = path;
                var response = await _blogService.Update(dto);
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
                dto.UpdateTime = DateTime.Now;
                var response = await _blogService.Update(dto);
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
}
