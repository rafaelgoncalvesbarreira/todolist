using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Business.Contract.Services;
using ToDoList.Mvc.Models.ViewModel;

namespace ToDoList.Mvc.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _service;
        private readonly IMapper _mapper;
        public TaskController(ITaskService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: Task
        public ActionResult Index()
        {
            return View();
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
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                var model = new TaskToDoViewModel();
                if (await TryUpdateModelAsync<TaskToDoViewModel>(model))
                {

                    // var task = _mapper.Map<Task>


                    return RedirectToAction(nameof(Index));

                }

                return View();
            }
            catch
            {
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