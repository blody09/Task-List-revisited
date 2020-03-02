using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskListRevisited.Models;

namespace TaskListRevisited.Controllers
{
    [Authorize]
    public class TasksController : Controller
    {
        
        private readonly IdentityTaskListDbContext _context;
        public TasksController(IdentityTaskListDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            string Id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            List<Tasks> thisUsersTasks = _context.Tasks.Where(x => x.TaskOwnerId == Id).ToList();
            return View(thisUsersTasks);
        }

        [HttpGet]
        public IActionResult AddTasks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTasks(Tasks newTask)
        {
            newTask.TaskOwnerId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (ModelState.IsValid)
            {
                _context.Tasks.Add(newTask);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        public IActionResult DeleteTasks(int id)
        {
            Tasks foundTask = _context.Tasks.Find(id);
            if (foundTask != null)
            {
                _context.Remove(foundTask);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTasks(int id)
        {
            Tasks foundTask = _context.Tasks.Find(id);
            return View(foundTask);
        }

        [HttpPost]
        public IActionResult UpdateTasks(Tasks updatedTasks)
        {
            Tasks dbTasks = _context.Tasks.Find(updatedTasks.Id);
            if (ModelState.IsValid)
            {
                dbTasks.TaskDescription = updatedTasks.TaskDescription;
                dbTasks.DueDate = updatedTasks.DueDate;
                dbTasks.Complete = updatedTasks.Complete;

                //when using _context.Update, you need to change the Entry state.
                _context.Entry(dbTasks).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(dbTasks);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}