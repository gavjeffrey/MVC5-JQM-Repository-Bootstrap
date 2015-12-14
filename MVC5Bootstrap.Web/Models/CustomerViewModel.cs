using System.ComponentModel.DataAnnotations;

namespace MVC5Bootstrap.Web.Models
{
    public class CustomerViewModel
    {
        [Required]
        [Display(Name = "First name")]        
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Surname")]        
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }
    }
}