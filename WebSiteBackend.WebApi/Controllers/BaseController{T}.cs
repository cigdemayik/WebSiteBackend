using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Entities.Abstracts.Interfaces;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity> : ControllerBase
        where TEntity : class, ITable, new()
    {
        private readonly IGenericService<TEntity> _genericService;

        public BaseController(IGenericService<TEntity> genericService)
        {
            _genericService = genericService;
        }

        [HttpGet]
        public IActionResult GelAll()
        {
            var response = _genericService.GetAll();
            if (response.IsSuccessful == true)
            {
                return Ok(response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }


        [HttpPost]
        public IActionResult Create(TEntity entity)
        {
            var response = _genericService.Create(entity);
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

        [HttpPut]
        public IActionResult Update(TEntity entity)
        {
            var response = _genericService.Update(entity);
            if (response.IsSuccessful == true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = _genericService.Delete(id);
            if (response.IsSuccessful == true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _genericService.GetAllAsync();
            if (response.IsSuccessful==true)
            {
                return Ok(response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        public async Task<IActionResult> UpdateAsync(TEntity entity)
        {
            var response = await _genericService.UpdateAsync(entity);
            if (response.IsSuccessful==true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        public async Task<IActionResult> CreateAsync(TEntity entity)
        {
            var response = await _genericService.CreateAsync(entity);
            if (response.IsSuccessful==true)
            {
                return Created("", response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        public async Task<IActionResult> DeleteAsync(int id)
        {
            var response = await _genericService.DeleteAsync(id);
            if (response.IsSuccessful==true)
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
