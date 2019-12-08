using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SessionDemo.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Jméno musí být vyplněno.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Příjmení musí být vyplněno.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Třída musí být vyplněna.")]
        public string Classroom { get; set; }
    }
}
