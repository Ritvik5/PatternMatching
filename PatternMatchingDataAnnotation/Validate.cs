using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingDataAnnotation
{
    public class Validate
    {
        public static void Validation()
        {
            Employee employee = new Employee();

            employee.FirstName = "Ritvik";
            employee.LastName = "Sharma";
            employee.Email = "death.note56@gmail.com";
            employee.PhoneNumber = "91 9234567890";

            ValidationContext validation = new ValidationContext(employee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(employee, validation, results, true);
            if (valid)
            {
                Console.WriteLine($"FirstName: {employee.FirstName}\nLastName: {employee.LastName}\nEmailAddress: {employee.Email}\nPhoneNumber: {employee.PhoneNumber}");
                Console.WriteLine("\nAre Valid");
            }
            else
            {
                foreach (ValidationResult result in results)
                {
                    Console.WriteLine(result.ErrorMessage);
                }
            }
        }
    }
}
