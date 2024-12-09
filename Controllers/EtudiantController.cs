using Microsoft.AspNetCore.Mvc;

using mvc.Models;

namespace mvc.Controllers;
public class EtudiantController : Controller {
     private static List<Etudiant> _etudiants = new List<Etudiant>
    {
        new Etudiant { Id = 1, Nom = "Alice", Age = 20, Specialite = "Informatique" },
        new Etudiant { Id = 2, Nom = "Bob", Age = 22, Specialite = "Mathématiques" },
        new Etudiant { Id = 3, Nom = "Charlie", Age = 21, Specialite = "Physique" }
    };
public IActionResult Index()
    {
        return View(_etudiants);
    }
public IActionResult ShowDetails(int id)
    {
    var etudiant = _etudiants.FirstOrDefault(e => e.Id == id);
    if (etudiant == null)
    {
        return NotFound();
    }
    return View(etudiant);
    }
[HttpPost]
public IActionResult Add(Etudiant etudiant)
{
    if (ModelState.IsValid)
    {
        etudiant.Id = _etudiants.Max(e => e.Id) + 1;
        _etudiants.Add(etudiant);
        return RedirectToAction(nameof(Index));
    }
    return View(etudiant);
}
public IActionResult Delete(int id)
{
    var etudiant = _etudiants.FirstOrDefault(e => e.Id == id);
    if (etudiant == null)
    {
        return NotFound();
    }
    return View(etudiant);
}

[HttpPost, ActionName("Delete")]
public IActionResult DeleteConfirmed(int id)
{
    var etudiant = _etudiants.FirstOrDefault(e => e.Id == id);
    if (etudiant != null)
    {
        _etudiants.Remove(etudiant);
    }
    return RedirectToAction(nameof(Index));
}
}
   
