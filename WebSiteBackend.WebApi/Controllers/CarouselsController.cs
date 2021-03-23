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
    public class CarouselsController:BaseController<Carousel>
    {
        private readonly ICarouselService _carouselService;

        public CarouselsController(ICarouselService carouselService, IGenericService<Carousel> genericService):base(genericService)
        {
            _carouselService = carouselService;
        }

       
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response=_carouselService.GetById(id);
            return Ok();
        }

        
    }
}
