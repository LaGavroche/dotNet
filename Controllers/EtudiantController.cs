using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using mvc.Data;
using mvc.Models;

public class EtudiantController : Controller
{
    private readonly UserManager<Etudiant> _userManager;

    public EtudiantController(UserManager<Etudiant> userManager)
    {
        _userManager = userManager;
    }

    
    public async Task<IActionResult> Index()
    {
        // Récupérer la liste de tous les étudiants
        var etudiants = await _userManager.GetUsersInRoleAsync("Etudiant");
        return View(etudiants);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(Etudiant etudiant, string password)
    {
        if (!ModelState.IsValid)
        {
            return View(etudiant);
        }

        var result = await _userManager.CreateAsync(etudiant, password);
        if (result.Succeeded)
        {
            return RedirectToAction("Index");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return View(etudiant);
    }

    public async Task<IActionResult> ShowDetails(string id)
    {
        var etudiant = await _userManager.FindByIdAsync(id);
        if (etudiant == null)
        {
            return NotFound();
        }

        return View(etudiant);
    }
}