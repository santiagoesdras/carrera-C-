using System.Security.Cryptography;

class Program {
    static void Main (string [] args)
{
    string s = "Mi segundo programa";
    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
    Console.WriteLine(s);
    Console.Write("Ingrese su nombre: ");
    string? nombre = Console.ReadLine();
    Console.Write("Ingrese su edad: ");
    string? edad = Console.ReadLine();
    Console.Write("Ingrese su carrera: ");
    string? carrera = Console.ReadLine();
    Console.Write("Ingrese su carnet: ");
    string? carnet = Console.ReadLine();
    Console.Write("Presione cualquier tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    
    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
    Console.WriteLine(s);
    Console.WriteLine("Nombre: "+ nombre);
    Console.WriteLine("Edad: "+ edad);
    Console.WriteLine("Carrera: "+ carrera);
    Console.WriteLine("Carnet: "+ carnet);  
    Console.Write("Presione cualquier tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine($"Soy {nombre}, tengo {edad} años y estudio la carrera {carrera}, Mi numero de Carnet es:{carnet}");
    Console.ReadKey();  
 } 
}
