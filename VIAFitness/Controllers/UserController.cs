using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;
using ViaFitnessDataAccess.BusinessLogic;
using ViaFitnessDataAccess.Models;

namespace VIAFitness.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {

        // GET: User
        public UserModel GetById(string id)
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            //UserData
            

            return UserProcessor.GetUserById(userId);
        }
    }
}