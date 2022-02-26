using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDwithEntityFrameWork.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name="Employee Name")]
        [Required(ErrorMessage ="Employee Name can't be Empty !")]
        [MinLength(3,ErrorMessage ="Name must be minimum 3 char !")]
        [MaxLength(30,ErrorMessage ="Name must be maximum 30 char !")]
        public string Name { get; set; }

        [Display(Name = "Employee Email Address")]
        [Required(ErrorMessage = "Employee Email Address can't be Empty !")]
        [EmailAddress(ErrorMessage ="Email address is not valid !")]
        public string Email { get; set; }
        
        [Display(Name = "Employee Mobile Number")]
        [Required(ErrorMessage = "Mobile Number can't be Empty !")]
        [RegularExpression(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$", ErrorMessage ="Invalid mobile number!")]
        public string Mobile { get; set; }

        [Display(Name = "Employee Address")]
        [Required]
        [MaxLength(200,ErrorMessage ="Max 200 char !")]
        public string Address { get; set; }
    }
}
