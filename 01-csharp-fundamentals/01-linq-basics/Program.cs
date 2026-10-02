var users = new List<User>
{
    new User { Name = "Christian", Age = 35, IsActive = true },
    new User { Name = "Andrea", Age = 29, IsActive = true },
    new User { Name = "Miguel", Age = 40, IsActive = false },
    new User { Name = "Carlos", Age = 25, IsActive = true }
};

// Ejercicio 1: Obtener los nombres de los usuarios activos ordenados alfabéticamente
// var result = users
//     .Where(user => user.IsActive)
//     .OrderBy(user => user.Name)
//     .Select(user => user.Name);

// Ejercicio 2: Obtener los nombres de los usuarios activos mayores o iguales a 30 años ordenados por edad
var result = users
    // .Where(user => user.Age >= 30 && user.IsActive)
    .Where(user => user.Age >= 30)
    .Where(user => user.IsActive)
    .OrderBy(user => user.Age)
    .Select(user => user.Name);

foreach (var name in result)
{
    Console.WriteLine(name);
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }
}