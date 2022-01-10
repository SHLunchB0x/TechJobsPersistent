using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// Might be an error on this page related to plurality. Check EMPLOYERS. Also ABOUT might be wrong, maybe ask Dennis.

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel addEmployerviewmodel = new AddEmployerViewModel();

            return View(addEmployerviewmodel);
        }
        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };
                context.Employers.Add(newEmployer);
                context.SaveChanges();

                return Redirect("/Employer");
            }
            return View("Add", addEmployerViewModel);
        }

        public IActionResult About(int id)
        {
            Employer selectedEmployer = context.Employers.Find(id);
            return View(selectedEmployer);
        }
    }
}
