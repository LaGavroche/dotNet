le fichier csproj c'est le contenant de notre projet. 
La solution elle est le contenant de nos projets
Le point d'entr�e de notre programme en C# c'est un fichier qui se nomme programme.cs

# le pattern Model View Controller

user -> view
view -> send inputes to Controller -> update Model -> Notify Controller
Model -> updates View
n�cessite une DB pour fonctionner en temps r�el

# Le but du pattern MVC et de structurer le code

structure de base d'un projet ASP.NET core MVC

MyMvcApp/
|-- Controller/
|  |__HomeController.cs
|-- Models/
|-- Views/
|  |-- Home/
|  |   |__Index.cshtml
|  | Shared/
|   | _Layout.cshtml
|-- wwwroot/
|  |-- css/
|  |-- js/
|  |- lib/
|-- appsettings.json
|-- program.cs
|-- Startup.css2

# normes en C#

en C# une classe = un fichier
on utiliser �galement un espace de noms (contenants virtuels)
permet de faciliter l'import et l'export de code source, on y stocke les  classes

# en .net on appelle les m�thodes de controller des "actions"

nb : tout ce qui est nomm� avec un underscore n'est pas destin� � �tre visible.
ne pas h�siter � couper l'app lorsqu'on fait des modifs de code (en killant le process)
le dossier model contiendra toute les classes qui vont structurer les donn�es qu'on a � l'�cran.

pour r�sumer : 

# Controllers
contiernt les controleurs de l'app 
par d�faut inclus homecontroller.cs
g�re la lotique de traitement des requetes http
# Models
contient les fhichiers de vue razor
...
...
...


