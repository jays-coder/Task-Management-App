using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class TaskController : Controller
    {
        private readonly AppDbContext _context;

        public TaskController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _context.Tasks.ToListAsync();
            return View(tasks);
        }
        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            task.CreatedOn = DateTime.Now;
            task.CreatedBy = "Admin";

            _context.Tasks.Add(task);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        
        [HttpPost]
        public IActionResult Edit(TaskItem task)
        {
            var existingTask = _context.Tasks.FirstOrDefault(t => t.Id == task.Id);

            if (existingTask != null)
            {
                existingTask.Title = task.Title;
                existingTask.Description = task.Description;
                existingTask.DueDate = task.DueDate;
                existingTask.Status = task.Status;
                existingTask.Remarks = task.Remarks;

                existingTask.UpdatedOn = DateTime.Now;
                existingTask.UpdatedBy = "Admin";

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
       
        public IActionResult Delete(int id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);

            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        //public IActionResult Details(int id)
        //{
        //    var task = _context.Tasks.FirstOrDefault(t => t.Id == id);

        //    if (task == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(task);
        //}
    }
}
