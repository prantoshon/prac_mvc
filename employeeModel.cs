using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bootstrap.Models
{
    public class employeeModel
    {
        public int EmployeeId { get; set; }
        [Required]

        public string EmployeeName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required(ErrorMessage = "Re-type Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Re-type Password Password dont match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        public int QuestionID { get; set; }
        [Required]
        public string Answer { get; set; }

        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastUpdatedBy { get; set; }
    }
}