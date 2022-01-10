using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Employer Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer Location is required")]
        public string Location { get; set; }
        public AddEmployerViewModel()
        {
        }
    }
}
