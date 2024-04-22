using MasodikProjeckt;

Teacher marcel = new Teacher("Matek Marcel", new DateTime(1981,10,25));
Console.WriteLine(marcel);
Teacher eva = new Teacher("Kis Éva", new DateTime(1981, 11, 25));
Console.WriteLine(eva);
if (marcel.DateOfBirth < eva.DateOfBirth)
    Console.WriteLine("Matek Marcel előbb született mint Kis Éva");
else if (marcel.DateOfBirth < eva.DateOfBirth)
    Console.WriteLine("Kis Éva előbb született mint Matek Marcel.");
else Console.WriteLine("A két tanár egy napon született!");

