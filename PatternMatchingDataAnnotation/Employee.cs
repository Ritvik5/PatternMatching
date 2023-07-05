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
        [StringLength(50,MinimumLength = 3,ErrorMessage = "Eg. abc.xyz@bl.co.in -Email has 3 mandatory parts (abc, bl& co) and 2 optional (xyz & in) with precise @ and . positions")]
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(15,MinimumLength = 10,ErrorMessage ="Country Code follow by space and 10 digit number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [StringLength(50,MinimumLength =8,ErrorMessage ="Should at least One Upper Case,One Numberic Number and has exactly One Special Character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
 