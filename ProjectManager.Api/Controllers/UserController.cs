﻿using ProjectManager.BusinessObjects;
using ProjectManager.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectManager.Api.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }
     [HttpGet]
     [Route("api/user")]
        public JsonResponse Get()
        {
            return new JsonResponse { Data = _userManager.GetUsers() };
        }
        

        [HttpPost]
        [Route("api/user/save")]
        public JsonResponse Save(User user)
        {
            return new JsonResponse { Data = _userManager.SaveUser(user) };
        }

        [HttpPost]
        [Route("api/user/delete")]
        public JsonResponse Delete(int userId)
        {
            return new JsonResponse { Data = _userManager.DeleteUser(userId) };
        }
    }
}