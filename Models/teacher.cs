using Microsoft.AspNetCore.Identity;

namespace mvc.Models;
public class Teacher : IdentityUser 

{

    public int Id {get; set;}
    public string Firstname {get; set;}
}