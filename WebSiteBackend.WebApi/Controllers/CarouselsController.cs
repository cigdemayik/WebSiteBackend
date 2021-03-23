using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselsController:ControllerBase
    {
        private readonly ICarouselService _carouselService;

        public CarouselsController(ICarouselService carouselService)
        {
            _carouselService = carouselService;
        }

        [HttpGet]
        public IActionResult GelAll()
        {
            var response=_carouselService.GetAll();
            if (response.IsSuccessful==true)
            {
                return Ok(response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_carouselService.GetById(id));
        }

        [HttpPost]
        public IActionResult Create(Carousel carousel)
        {
            var response = _carouselService.Create(carousel);
            if (response.IsSuccessful==true)
            {
                return Created("", response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
            
        }

        [HttpPut]
        public IActionResult Update(Carousel carousel)
        {
           var response= _carouselService.Update(carousel);
            if (response.IsSuccessful==true)
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
            var response=_carouselService.Delete(id);
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
