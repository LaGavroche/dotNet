using Microsoft.AspNetCore.Mvc;
using mvc.Data;
using mvc.Models;

public class EtudiantController : Controller
{
    // champ prive pour stocker le dbcontext
    private readonly ApplicationDbContext _context;

    // liste d'enseignants


    // Constructeur
    public EtudiantController(ApplicationDbContext context)
    {
        _context = context;
    }


    public IActionResult Index()
    {
        return View(_context.Students.ToList());
    }

    // Ecrire une liste d'Actions


    // Ajouter un Teacher
    // Accessible via /Teacher/Add en GET affichera le formulaire
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
        _context.Students.Add(etudiant);

        // Sauvegarder les changements
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    // Supprimer un Teacher

    // Afficher le détail d'un teacher
    // Accessible via /Teacher/ShowDetails/10
    public IActionResult ShowDetails(int id)
    {
        var etudiant = _context.Students.Find(id);
        return View(etudiant);
    }
}