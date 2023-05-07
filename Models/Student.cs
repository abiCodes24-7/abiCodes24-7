
using System;
using System.ComponentModel.DataAnnotations;
namespace asp_mvc.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please choose gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter data of birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }

        [Required(ErrorMessage = "Choose batch time")]
        [Display(Name = "Batch time")]
        [DataType(DataType.Time)]
        public DateTime BatchTime { get; set; }


        [Required(ErrorMessage = "please enter phone number")]
        [Display(Name = "phone number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "please enter email addess")]
        [Display(Name = "Email address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "please enter website Url")]
        [Display(Name = "Website Url")]
        [Url]
        public string website { get; set; }

        [Required(ErrorMessage = "please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "please confirm password")]
        [Display(Name = "Consfirm password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfirmPassword { get; set; }

    }
}
