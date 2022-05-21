using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_ProjectCRUD.Models
{
    public class EmpModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]

        public string EmpEmail { get; set; }

         [Required(ErrorMessage = "Required")]
         [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
         public string EmpMobile { get; set; }
        public string EmpAddress { get; set; }
        public System.DateTime DOB { get; set; }
        public string Password { get; set; }

    }
}