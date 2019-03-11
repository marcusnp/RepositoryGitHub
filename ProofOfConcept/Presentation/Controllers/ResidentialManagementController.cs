using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Repository.Configuration;
using Domain.Models;

namespace Presentation.Controllers
{
    public class ResidentialManagementController : Controller
    {
        DataContext _dbContext = new DataContext();

        public IActionResult Index()
        {
            var data = (from tenan in _dbContext.Tenancy
                        join compa in _dbContext.ResidentialManagement
                        on tenan.TenancyId equals compa.TenancyId
                        select new ResidentialManagement
                        {
                            ResidentialManagementId = compa.ResidentialManagementId,
                            Description = compa.Description,
                            Name = compa.Name,
                            TenancyId = compa.TenancyId,
                            TenancyName = tenan.Name
                        }).ToList();

            return View(data);
        }

        public IActionResult Create()
        {
            ViewBag.Tenancy = _dbContext.Tenancy.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ResidentialManagement model)
        {
            ModelState.Remove("ResidentialManagementId");
            if (ModelState.IsValid)
            {
                _dbContext.ResidentialManagement.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Tenancy = _dbContext.Tenancy.ToList();
            return View();
        }

    }
}