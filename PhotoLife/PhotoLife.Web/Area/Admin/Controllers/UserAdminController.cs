﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoLife.Authentication.Providers;
using PhotoLife.Services.Contracts;

namespace PhotoLife.Area.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UserAdminController : Controller
    {
        private readonly IUserService userService;
        private readonly IAuthenticationProvider authProvider;

        public UserAdminController(IUserService userService, IAuthenticationProvider authProvider)
        {
            if (userService == null)
            {
                throw new ArgumentNullException("userService");
            }

            if (authProvider == null)
            {
                throw new ArgumentNullException("authProvider");
            }

            this.userService = userService;
            this.authProvider = authProvider;
        }
        // GET: UserAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}