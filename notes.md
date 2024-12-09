le fichier csproj c'est le contenant de notre projet. 
La solution elle est le contenant de nos projets
Le point d'entrée de notre programme en C# c'est un fichier qui se nomme programme.cs

# le pattern Model View Controller

user -> view
view -> send inputes to Controller -> update Model -> Notify Controller
Model -> updates View
nécessite une DB pour fonctionner en temps réel

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
on utiliser également un espace de noms (contenants virtuels)
permet de faciliter l'import et l'export de code source, on y stocke les  classes

# en .net on appelle les méthodes de controller des "actions"

nb : tout ce qui est nommé avec un underscore n'est pas destiné à être visible.
ne pas hésiter à couper l'app lorsqu'on fait des modifs de code (en killant le process)
le dossier model contiendra toute les classes qui vont structurer les données qu'on a à l'écran.

pour résumer : 

# Controllers
contiernt les controleurs de l'app 
par défaut inclus homecontroller.cs
gère la lotique de traitement des requetes http
# Models
contient les fhichiers de vue razor
...
...
...


