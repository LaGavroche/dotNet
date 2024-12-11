using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace mvc.Models
{
    public class AccountViewModel : IdentityUser
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        

        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmedPassword { get; set; }
        
        
        [Required(ErrorMessage = "Le prenom est obligatoire")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le prenom doit comporter entre 2 et 50 caractères")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom doit comporter entre 2 et 50 caractères")]
        public string Lastname { get; set; }
        
        
        [Required(ErrorMessage = "La date de naissance est obligatoire")]
        [DataType(DataType.Date)]
        [Display(Name = "Date de naissance")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateNaissance { get; set; }


    }
}