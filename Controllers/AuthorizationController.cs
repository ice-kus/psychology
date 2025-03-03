﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Psychology.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Psychology.Data.Interfaces;
using System.Linq;


namespace Psychology.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly IStudentRepository _Student;
        private readonly ILecturerRepository _Lecturer;
        public AuthorizationController(IStudentRepository _Student, ILecturerRepository _Lecturer)
        {
            this._Student = _Student;
            this._Lecturer = _Lecturer;
        }
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(string TypeUser)
        {
            var Model = new AuthorizationViewModel
            {
                TypeUser = TypeUser
            };
            return View(Model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AuthorizationViewModel Model)
        {
            if (ModelState.IsValid)
            {
                switch(Model.TypeUser)
                {
                    case "Студент":
                        {
                            if (_Student.List.Any(u => u.Id.ToString() == Model.Login && u.Password == Model.Password))
                            {
                                await Authenticate(Model.Login, "Student"); // аутентификация

                                return RedirectToAction("Index", "StudentTest");
                            }
                            break;
                        }
                    case "Преподаватель":
                        {
                            if (_Lecturer.List.Any(u => u.Login == Model.Login && u.Password == Model.Password))
                            {
                                await Authenticate(_Lecturer.List.First(u => u.Login == Model.Login).Id.ToString(), "Lecturer"); // аутентификация

                                return RedirectToAction("Index", "LecturerTest");
                            }
                            break;
                        }
                    case "Администратор":
                        {
                            var Lecturer = _Lecturer.List.First(u => u.Id == 1);
                            if (Lecturer.Login == Model.Login && Lecturer.Password == Model.Password)
                            {
                                await Authenticate(Lecturer.Login, "Admin"); // аутентификация
                                return RedirectToAction("Index", "Admin");
                            }
                            break;
                        }
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(Model);
        }
        private async Task Authenticate(string Login, string Role)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, Role)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Authorization");
        }
    }
}