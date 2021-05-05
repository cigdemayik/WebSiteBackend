using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController:ControllerBase

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
        public async Task<IActionResult> Create([FromForm] Blog entity)
        {
            if (entity.Image.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\blogs\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\blogs\\");
                    }
                    var fileName = DateTime.Now.ToLongDateString()+"_" + entity.Image.FileName;
                    var path = Path.Combine(_environment.WebRootPath, "blogs/" + fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await entity.Image.CopyToAsync(stream);
                    }
                    entity.ImageUrl = path;
                    var response = _blogService.Create(entity);
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
        public IActionResult GetAll()
        {
            var response = _blogService.GetAll();
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
        public async Task<IActionResult> Update([FromForm]Blog entity)
        {
            if(entity.Image!=null && entity.Image.Length > 0)
            {
                var fileName = DateTime.Now.ToLongDateString() + "_" + entity.Image.FileName;
                var path = Path.Combine(_environment.WebRootPath, "blogs/" + fileName);

                using(var stream= new FileStream(path, FileMode.Create))
                {
                    await entity.Image.CopyToAsync(stream);
                }
                entity.ImageUrl = path;
                var response = _blogService.Update(entity);
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
                entity.ImageUrl = _blogService.GetByIdAsNoTracking(entity.Id).Result.ImageUrl;
                var response = _blogService.Update(entity);
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
            var response = _blogService.Delete(id);
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
