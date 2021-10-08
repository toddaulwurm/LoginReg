using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// ^This last one is for the NotMapped on confirm password!
namespace LoginReg.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="You need at least 8 characters in your password!")]
        public string Password {get;set;}

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}