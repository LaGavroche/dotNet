using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Data;

public class ApplicationDbContext : IdentityDbContext<Etudiant>
{
    // créer Dbset pour chaque table
    // Dbset est une classe qui represente une table
    // Elle permet de faire le mapping entre la table et la classe C#
    //public DbSet<Etudiant> Students {get; set;}
    // gere par IdentityDbContext maintenant
    public DbSet<Etudiant> Etudiants {get; set;}

    // Constructeur de la classe
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}