using Microsoft.AspNetCore.Mvc;
using mvc.Data;
using mvc.Models;

public class EtudiantController : Controller
{
    // champ prive pour stocker le dbcontext
    private readonly ApplicationDbContext _context;

    // liste d'enseignants
    private static List<Etudiant> _etudiant = new List<Etudiant>
    {
        new Etudiant { Id = 1, Nom = "Doe", Prenom = "John" },
        new Etudiant { Id = 2, Nom = "Smith", Prenom = "Jane" }
    };

    // Constructeur
    public EtudiantController(ApplicationDbContext context)
    {
        _context = context;
    }


    public IActionResult Index()
    {
        return View(_etudiant);
    }


    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    // Accessible via /Teacher/Add en POST ajoutera le teacher
    [HttpPost]
    public IActionResult Add(Etudiant etudiant)
    {
        // Declencher le mecanisme de validation
        if (!ModelState.IsValid)
        {
            return View();
        }
        // Ajouter le teacher
        // _context.Teachers.Add(teacher);

        // Sauvegarder les changements
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    // Supprimer un Teacher

    // Afficher le détail d'un teacher
    // Accessible via /Teacher/ShowDetails/10
    public IActionResult ShowDetails(int id)
    {
        //var teacher = _context.Teachers.Find(id);
        // return View(teacher);
        return View();
    }



}