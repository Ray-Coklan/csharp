using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
 
namespace formsub.Models
{
    public abstract class BaseEntity
    {
       
    }
    public class User 
    {
        [Required(ErrorMessage="First Name field is required.")]
        [MinLength(2, ErrorMessage="First Name should be more than 2 characters!")]
        public string firstname { get; set; }

        [Required(ErrorMessage="Last Name field is required.")]
        [MinLength(2, ErrorMessage="Last Name should be more than 2 characters!")]
        public string lastname { get; set; }

        [Required(ErrorMessage="Age field is required.")]
        [Range(0,120,ErrorMessage="Age must be between 0 and 120")]
        public string age { get; set; }
 
        [Required(ErrorMessage="Email Address field is required.")]
        [EmailAddress]
        public string email { get; set; }
 
        [Required(ErrorMessage="Password field is required")]
        [MinLength(8, ErrorMessage="Password be more than 8 characters!")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}