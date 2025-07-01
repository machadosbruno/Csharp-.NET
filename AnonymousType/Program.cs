var obj = new
{
    firstName = "King",
    lastName = "Kochhar",
    salary = 12000,
    address = new { streetname = "Civil Lines", city = "Delhi" },
    projects = new[]{
        new { projectName = "ECommerce", projectDuration = "40 Hours" },
        new { projectName = "Admin Portal", projectDuration = "25 Hours" },
        new { projectName = "Accounting", projectDuration = "20 Hours" }
    }
};

Console.WriteLine(obj.firstName);
Console.WriteLine(obj.lastName);
Console.WriteLine(obj.salary);

Console.WriteLine(obj.address.streetname);

foreach (var project in obj.projects) {
    Console.WriteLine(project.projectName);
    Console.WriteLine(project.projectDuration);
}