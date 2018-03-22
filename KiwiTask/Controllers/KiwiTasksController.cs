// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KiwiTasksController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the KiwiTasksController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace KiwiTask.Controllers
{
    using KiwiTask.Models;
    using KiwiTask.ViewModels;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Web.Mvc;

    public class KiwiTasksController : Controller
    {
        public readonly ApplicationDbContext _context;

        public KiwiTasksController()
        {
            this._context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var model = new KiwiTaskViewModel();
            return this.View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(KiwiTaskViewModel viewModel)
        {
            var task = new KiwiTask
            {
                AddDate = DateTime.Today,
                Name = viewModel.TaskName,
                Description = viewModel.TaskDescription,
                OwnerId = User.Identity.GetUserId(),
                DueDate = DateTime.Parse(viewModel.DueDate)
            };
            this._context.Tasks.Add(task);
            this._context.SaveChanges();
            return RedirectToAction("Index", "KiwiTasks");
        }

        [Authorize]
        public ActionResult Index()
        {
            var tasks = this._context.Tasks;
            return this.View(tasks);
        }
    }
}