using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tomorowland.Models;
using Tomorowland.Models.Login;
using Tomorowland.Models.Auto;
using Tomorowland.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Tomorowland.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Out()
        {
          
            return View(await db.Cars.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Car car)
        {
            db.Cars.Add(car);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Car car = await db.Cars.FirstOrDefaultAsync(p => p.Id == id);
                if (car != null)
                    return View(car);
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Car car = await db.Cars.FirstOrDefaultAsync(p => p.Id == id);
                if (car != null)
                    return View(car);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Car car)
        {
            db.Cars.Update(car);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Car car = await db.Cars.FirstOrDefaultAsync(p => p.Id == id);
                if (car != null)
                    return View(car);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Car car = await db.Cars.FirstOrDefaultAsync(p => p.Id == id);
                if (car != null)
                {
                    db.Cars.Remove(car);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        public IActionResult Index()
        {
            return View();
        }
       

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
