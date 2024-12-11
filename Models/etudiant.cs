namespace mvc.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
public class Etudiant : IdentityUser
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Le nom est obligatoire")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom doit comporter entre 2 et 50 caractères")]
    public string Nom { get; set; }

    [Range(18, 99, ErrorMessage = "L'âge doit être compris entre 18 et 99")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Le prenom est obligatoire")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Le prenom doit comporter entre 2 et 50 caractères")]
    public string Prenom {get; set;}
    
    [Required]
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email {get; set;}


    [Required(ErrorMessage = "La date de naissance est obligatoire")]
    [DataType(DataType.Date)]
    [Display(Name = "Date de naissance")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime DateNaissance {get; set;}

}