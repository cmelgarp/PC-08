using System;

namespace Actividad1_Semana_18;

public class Notas
{
    public string NombreAlumno {get; set;}
    public int[] NotasAlumnos = new int [10]; 

    public Notas ( int[] notasAlumnosIngresadas, string nombreAlumnoIngresado)
    {
        this.NotasAlumnos = notasAlumnosIngresadas;
        this.NombreAlumno = nombreAlumnoIngresado; 
    }

    public int PromedioGeneral()
    {
        int resultadoNota = 0; 
        for(int i = 0; i<10; i++)
        {
            resultadoNota += NotasAlumnos[i];
        }
        resultadoNota /= 10;

        return resultadoNota;
    }

    public void AlumnosAprobados()
    {
        foreach (int i in NotasAlumnos)
        {
            if (i >= 65)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void AlumnosDesaprobados()
    {
        foreach (int i in NotasAlumnos)
        {
            if (i < 65)
            {
                Console.WriteLine(i);
            }
        }
    }

}
