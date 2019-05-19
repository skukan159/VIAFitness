using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIAFitness.Models;
using ViaFitnessDataAccess.BusinessLogic;
using ViaFitnessDataAccess.Models;

namespace VIAFitness.Controllers
{
    [Authorize]
    public class WorkoutController : Controller
    {
        // GET: Workout // Index()
        public ActionResult Index()

        {
            var userId = User.Identity.GetUserId();
            List<WorkoutModel> workouts =  WorkoutProcessor.GetWorkoutsByUserId(userId);

            List<DisplayWorkoutViewModel> displayedWorkouts = new List<DisplayWorkoutViewModel>();
            foreach(WorkoutModel workout in workouts)
            {
                DisplayWorkoutViewModel addedWorkout = new DisplayWorkoutViewModel();
                addedWorkout.WorkoutId = workout.Id;
                addedWorkout.WorkoutType = workout.Type;
                addedWorkout.CreatedDate = workout.CreateDate;
                displayedWorkouts.Add(addedWorkout);
            }

            return View(displayedWorkouts);
        }

        // GET: Workout/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Workout/Create
        public ActionResult CreateWorkout()
        {
            return View();
        }

        // POST: Workout/Create
        [HttpPost]
        public ActionResult CreateWorkout(CreateWorkoutViewModel createdWorkout/*FormCollection collection*/)
        {
            var userId = User.Identity.GetUserId();

            try
            {
                var result = WorkoutProcessor.CreateWorkout(userId, createdWorkout.WorkoutType,createdWorkout.CreateDate);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Workout/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Workout/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UpdateWorkoutViewModel updatedWorkout)
        {
            updatedWorkout.WorkoutId = id;
            try
            {
                int success = WorkoutProcessor.UpdateWorkout(updatedWorkout.WorkoutId, updatedWorkout.WorkoutType, updatedWorkout.CreateDate);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                throw (ex);
             //   return View();
            }
        }

        // GET: Workout/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
               WorkoutProcessor.DeleteWorkout(id);
            }
            catch (Exception)
            {

                throw;
            }


            return View();
        }

        // POST: Workout/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}