using System;

namespace Actividad1_Semana_18;

public class Notas
{
    public string nombreAlumno {get; set;}
    public int[] notasAlumnos = new int [10]; 

    public Notas ( int[] notasAlumnosIngresadas, string nombreAlumnoIngresado)
    {
        this.notasAlumnos = notasAlumnosIngresadas;
        this.nombreAlumno = nombreAlumnoIngresado; 
    }

    public int promedioGeneral()
    {
        int resultadoNota = 0; 
        for(int i = 0; i<10; i++)
        {
            resultadoNota =+ notasAlumnos[i];
        }

        return resultadoNota;
    }

    public void alumnosAprovados()
    {
        foreach (int i in notasAlumnos)
        {
            if (i >= 65)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void alumnosDesaprovados()
    {
        foreach (int i in notasAlumnos)
        {
            if (i < 65)
            {
                Console.WriteLine(i);
            }
        }
    }

}
