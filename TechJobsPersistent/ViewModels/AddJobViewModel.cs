using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }

        public List<Skill> Skills { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();

            foreach (Employer employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    });
            }
            Skills = skills;
        }

        public AddJobViewModel()
        {

        }
    }
}
