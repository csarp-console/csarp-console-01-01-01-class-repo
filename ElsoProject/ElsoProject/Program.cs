// See https://aka.ms/new-console-template for more information
using ElsoProject;

Student adel = new Student("Kis Adél", 17);
Console.WriteLine(adel);
Student janos = new Student("Kis János", 17);
Console.WriteLine(janos);
if (Student.EqualTo(adel, janos))
    Console.WriteLine("Két diák adatai megegyeznek!");
else
    Console.WriteLine("Két diák adatai nem egyeznek meg");
