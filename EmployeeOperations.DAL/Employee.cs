using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOperations.DAL
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Email field can't blank")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password field can't blank")]
        public string Password { get; set; }
    }
}
