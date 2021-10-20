﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.UserDtos;

namespace WebSiteBackend.WebUI.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public IActionResult Index()
        {
            return View(new UserLoginDto());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginDto dto)
        {
            var response = _userService.SignIn(dto);
            if (!response.IsSuccessful)
            {
                ViewBag.Message = response.ErrorMessage;
                return View(dto);
            }

            var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,response.Result.UserId.ToString()),
                    new Claim(ClaimTypes.Role, response.Result.Token.ToString()),
                    new Claim(ClaimTypes.Name, response.Result.Username.ToString())
                };

            var identity = new ClaimsIdentity(claims, "Custom Identity");

            var userPrincipal = new ClaimsPrincipal(new[] { identity });

            await HttpContext.SignInAsync(userPrincipal);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult LogOut()
        {
            HttpContext.Response.Cookies.Delete("WebSite.Cookie");

            return RedirectToAction("Index", "Account");
        }
    }
}
