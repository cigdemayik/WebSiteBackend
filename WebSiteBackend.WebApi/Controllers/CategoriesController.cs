using Microsoft.AspNetCore.Mvc;
using WebSiteBackend.Business.Abstracts.Interfaces;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
             _categoryService= categoryService;
        }

    }
}
