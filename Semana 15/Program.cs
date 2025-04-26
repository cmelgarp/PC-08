using System;
using System.Runtime.CompilerServices;
public class Estudiante
{
    string NombreEstudiante;
    int EdadEstudiante;    string CarreraEstudiante;
    string CarnetEstudiante;
    int NotaAdmision;
    public static void Main()
    {
        Console.WriteLine("Ingrese su nombre: ");
        var NombreEstudiante = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Ingrese su edad: ");
        int EdadEstudiante = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ingrese su carrera: ");
        var CarreraEstudiante = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Ingrese su carnet: ");
        var CarnetEstudiante = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Ingrese su nota de admision: ");
        int NotaAdmision = Convert.ToInt16(Console.ReadLine());

        Estudiante MostrarResumen = new Estudiante(EdadEstudiante, CarnetEstudiante!, NotaAdmision, NombreEstudiante!, CarreraEstudiante!);
        MostrarResumen.show();
       if(MostrarResumen.PuedeMatricular() == true ) 
       {
            Console.WriteLine("Cumples las condiciones para matricularse.");
       }
       else
       {
            Console.WriteLine("No cumples con las condiciones para matricularte.");
       }

    }
    Estudiante (int EdadEstudiante, string CarnetEstudiante, int NotaAdmision, string NombreEstudiante, string CarreraEstudiante) {
        this.EdadEstudiante = EdadEstudiante;
        this.CarnetEstudiante = CarnetEstudiante;
        this.NotaAdmision = NotaAdmision;
        this.NombreEstudiante = NombreEstudiante;
        this.CarreraEstudiante = CarreraEstudiante;
    }
    public void show() {
        Console.WriteLine("Tu nombre es: " + NombreEstudiante);
        Console.WriteLine("Tu edad es: " + EdadEstudiante);
        Console.WriteLine("Tu carrera es: " + CarreraEstudiante);
        Console.WriteLine("Tu carnet es: " + CarnetEstudiante);
        Console.WriteLine("Tu nota de admision es de: " + NotaAdmision);
    }

    public bool PuedeMatricular ()
    {
        
        if (NotaAdmision >= 75 && CarnetEstudiante.EndsWith("25"))
        {
            return true;
        } 
        else 
        {
            return false;
        }
    }
}
