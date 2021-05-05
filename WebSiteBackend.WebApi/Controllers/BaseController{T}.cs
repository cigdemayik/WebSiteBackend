using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAll()
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
    }
}
