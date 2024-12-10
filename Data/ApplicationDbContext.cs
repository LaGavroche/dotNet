using Microsoft.EntityFrameworkCore;
using  mvc.Models;

namespace mvc.Data;

public class ApplicationDbContext : DbContext
{
    // créer Dbset pour chaque table
    // Dbset est une classe qui represente une table
    // Elle permet de faire le mapping entre la table et la classe C#
    public DbSet<Etudiant> Students {get; set;}
    public DbSet<Teacher> Teachers {get; set;}

    // Constructeur de la classe
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}