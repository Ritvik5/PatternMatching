using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingDataAnnotation
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee{0} is required")]
        [StringLength(50,MinimumLength = 3,ErrorMessage = "First name starts with Cap and has minimum 3 characters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [StringLength(50,MinimumLength = 3,ErrorMessage = "LastName starts with Cap and of minimum 3 characyters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
    }
}
 