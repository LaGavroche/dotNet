using System.ComponentModel.DataAnnotations;

public class Etudiant

{
    public int Id { get; set; }

    [Required(ErrorMessage = "Le nom est obligatoire")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom doit comporter entre 2 et 50 caractères")]
    public string Nom { get; set; }

    [Range(18, 99, ErrorMessage = "L'âge doit être compris entre 18 et 99")]
    public int Age { get; set; }

    [Required(ErrorMessage = "La spécialité est obligatoire")]
    [Display(Name = "Domaine d'étude")]
    public string Specialite { get; set; }
}