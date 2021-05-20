using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _userService.GetAllAsync();
            if (result.IsSuccessful)
            {
                return View(result.Result);
            }
            return BadRequest(result.ErrorMessage);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new User());
        }
        [HttpPost]
        public async Task<IActionResult> Create(User model)
        {
            var result = await _userService.CreateAsync(model);
            if (result.IsSuccessful)
            {
                return RedirectToAction("Index");
            }
            return BadRequest(result.ErrorMessage);
        }
        [HttpGet("{id}/User")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await _userService.DeleteAsync(id);
            }
            return RedirectToAction("Index");
        }
        //[HttpGet("{id}")]
        public async Task<IActionResult> Update(int id)
        {
            if (ModelState.IsValid)
            {
                var result = _userService.GetById(id);
                if (result.IsSuccessful)
                {
                    return View(result.Result);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(User model)
        {
            if (ModelState.IsValid)
            {
                await _userService.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest("Parametreler Uyuşmadı");
            }
        }
    }
}
