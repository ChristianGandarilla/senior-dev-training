using System.Runtime.CompilerServices;

var users = new List<User>
{
    new User { Name = "Christian", Age = 35, IsActive = true },
    new User { Name = "Andrea", Age = 29, IsActive = true },
    new User { Name = "Miguel", Age = 40, IsActive = false },
    new User { Name = "Carlos", Age = 25, IsActive = true }
    // new User { Name = "Christian", Age = 40, IsActive = true }
};

/* Ejercicio 1: Obtener los nombres de los usuarios activos ordenados alfabéticamente
// var result = users
//     .Where(user => user.IsActive)
//     .OrderBy(user => user.Name)
//     .Select(user => user.Name);
*/
/* Ejercicio 2: Obtener los nombres de los usuarios activos mayores o iguales a 30 años ordenados por edad
// var result = users
//     // .Where(user => user.Age >= 30 && user.IsActive)
//     .Where(user => user.Age >= 30)
//     .Where(user => user.IsActive)
//     .OrderBy(user => user.Age)
//     .Select(user => user.Name);
// foreach (var name in result)
// {
//     Console.WriteLine(name);
// }
*/
/* Ejercicio 3: Pregunta de cuestionario...
// Ejercicio 4: Obtener el primer usuario activo mayor o igual a 30 años
// var result = users
//     .Where(u => u.Age >= 30 && u.IsActive)
//     .FirstOrDefault();
    
// Console.WriteLine($"Name: {result.Name}, Age: {result.Age}, IsActive: {result.IsActive}");
*/
/* Ejercicio 5: First() vs FirstOrDefault()
// var result = users
//     .Where(u => u.Age >= 30 && u.IsActive)
//     .FirstOrDefault();
    
//     if (result != null)
//     {
//         Console.WriteLine($"Name: {result.Name}, Age: {result.Age}, IsActive: {result.IsActive}");
//     }
//     else
//     {
//         Console.WriteLine("No se encontró ningún usuario activo mayor o igual a 30 años.");
//     }
*/
/* Ejercicio 6: Single() vs First()
new User { Name = "Christian", Age = 40, IsActive = true };

var result = users
    .Where(u => u.Name == "Christian")
    .SingleOrDefault();
    
    if (result != null)
    {
        Console.WriteLine($"Name: {result.Name}, Age: {result.Age}, IsActive: {result.IsActive}");
    }
    else
    {
        Console.WriteLine("No user found.");
    }
*/
/* Ejercicio 7: Obtener el primer usuario con nombre "Fernando" o null si no existe
var result = users
    .Where(u => u.Name == "Fernando")
    .FirstOrDefault();
    
    if (result != null)
    {
        Console.WriteLine($"Name: {result.Name}, Age: {result.Age}, IsActive: {result.IsActive}");
    }
    else
    {
        Console.WriteLine("No user found.");
    }
*/

var totalAge = users.Sum(u => u.Age);
var averageAge = users.Average(u => u.Age);
Console.WriteLine($"Total age of all users: {totalAge}");
Console.WriteLine($"Average age of all users: {averageAge}");

public class User
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public bool IsActive { get; set; }
}