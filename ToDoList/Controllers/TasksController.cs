using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoList.Business.Contract.Services;
using ToDoList.Model;
using ToDoList.Mvc.Models.ViewModel;

namespace ToDoList.Mvc.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<TasksController> _logger;

        public TasksController(ITaskService service, IMapper mapper, ILogger<TasksController> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: Task
        public ActionResult Index()
        {
            var tasks = _service.GetAll().ToList();
            var models = _mapper.Map<IList<TaskToDo>,IList<TaskToDoViewModel>>(tasks);
            return View(models);
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create(IFormCollection collection)
        public ActionResult Create(TaskToDoViewModel model)
        {
            try
            {
                //var model = new TaskToDoViewModel();
                //if (await TryUpdateModelAsync<TaskToDoViewModel>(model))
                //{

                    var task = _mapper.Map<TaskToDo>(model);
                    _service.Create(task);

                    return RedirectToAction(nameof(Index));

                //}

                //return View();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return View();
            }
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Task/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}