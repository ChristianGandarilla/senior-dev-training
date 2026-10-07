using System.Runtime.CompilerServices;

var users = new List<User>
{
    new User { Name = "Christian", Age = 35, IsActive = true },
    new User { Name = "Andrea", Age = 29, IsActive = true },
    new User { Name = "Miguel", Age = 40, IsActive = false },
    new User { Name = "Carlos", Age = 25, IsActive = true },
    // new User { Name = "Fernando", Age = 40, IsActive = true }
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
/* Ejercicio 8: Obtener el total y promedio de edad de todos los usuarios
var totalAge = users.Sum(u => u.Age);
var averageAge = users.Average(u => u.Age);
Console.WriteLine($"Total age of all users: {totalAge} - Type: {totalAge.GetType()}");
Console.WriteLine($"Average age of all users: {averageAge} - Type: {averageAge.GetType()}");

var activeUsers = users.Count(u => u.IsActive);
var averageActiveAge = users.Where(u => u.IsActive).Average(u => u.Age);
Console.WriteLine($"Total active users: {activeUsers}");
Console.WriteLine($"Average age of active users: {averageActiveAge:F2}");

var result = users
    .Where(u => u.Age >= 35 && u.IsActive)
    .Select(u => new { u.Name, u.Age })
    .OrderByDescending(u => u.Age);

foreach (var user in result)
{
    Console.WriteLine($"{user.Name} - {user.Age}");
}
*/
/* Ejercicio 9: Obtener los nombres de los usuarios activos con la edad mayor o igual que 25, ordenados alfabeticamente.
var result = users
    .Where(u => u.IsActive && u.Age >= 25)
    .OrderBy(u => u.Name)
    .Select(u => u.Name);

foreach (var name in result)
{
    Console.WriteLine(name);
}
*/
/* Ejercicio 10
var result = users
    .Where(u => u.IsActive)
    .ToList();

Console.WriteLine($"Users: {users.Count}");
Console.WriteLine($"Result: {result.Count}");

users.Add(new User
{
    Name = "Fernando",
    Age = 28,
    IsActive = true
});

Console.WriteLine($"Users after adding Fernando: {users.Count}");
Console.WriteLine($"Result after adding Fernando: {result.Count}");

var activeUsers = users
    .Where(u => u.IsActive);

var activeUsersList = users
    .Where(u => u.IsActive)
    .ToList();

users.Add(new User
{
    Name = "Fernando",
    Age = 28,
    IsActive = true
});

Console.WriteLine(activeUsers.Count());
Console.WriteLine(activeUsersList.Count());
*/
/* Ejercicio 11: Diferencias entre IEnumerable y List
var result = users
    .Where(u => u.IsActive);

Console.WriteLine(result.GetType());

IEnumerable<User> result = users
    .Where(u => u.IsActive);

Console.WriteLine(result.GetType());

List<User> result = users
    .Where(u => u.IsActive)
    .ToList();

Console.WriteLine(result.GetType());

var a = users.Where(u => u.IsActive);
IEnumerable<User> b = users.Where(u => u.IsActive);
List<User> c = users.Where(u => u.IsActive).ToList();

Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());
Console.WriteLine(c.GetType());

var activeUsers = db.Users
    .Where(u => u.IsActive)
    .OrderBy(u => u.Name)
    .ToList();
*/

public class User
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public bool IsActive { get; set; }
}