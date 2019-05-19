using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIAFitness.Models;
//using System.Web.Mvc;
using ViaFitnessDataAccess.BusinessLogic;
using ViaFitnessDataAccess.Models;

namespace VIAFitness.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        public ActionResult Index()
        {

            List<UserModel> users = UserProcessor.LoadUser();
            List<UserViewModel> displayedUsers = new List<UserViewModel>();
            foreach(UserModel user in users)
            {
                UserViewModel addUser = new UserViewModel { Id = user.Id, Email = user.EmailAddress, FirstName = user.FirstName, LastName = user.LastName };
                displayedUsers.Add(addUser);
            }

            return View(displayedUsers);
        }

    }
}