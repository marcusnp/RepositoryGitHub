using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Repository.Configuration;
using Domain.Models;
namespace Presentation.Controllers
{
    public class TenancyController : Controller
    {
        DataContext _dbContext = new DataContext();

        public IActionResult Index()
        {
            List<Tenancy> data = this._dbContext.Tenancy.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tenancy model)
        {
            ModelState.Remove("TenancyId");
            if (ModelState.IsValid)
            {
                _dbContext.Tenancy.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}