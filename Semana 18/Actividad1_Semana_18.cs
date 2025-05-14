namespace Actividad1_Semana_18;

class Program
{
    
    static int ValidarNumero(string entradaDeUsuario)
    {
         int numero;
    
        while(true)
        {
            if (int.TryParse(entradaDeUsuario, out numero))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Entrada inválida. Inténtalo de nuevo.");
                Console.WriteLine("Ingresa nuevamente la nota: ");
                entradaDeUsuario = Console.ReadLine()!;
            }
        } 

        return numero; 
    }
    static public void promedioTotal (){
        int promedioGeneral = 0; 
        for (int i = 0; i < 10; i++)
        {
            promedioGeneral =+ alumnosIngresados[i].promedioGeneral();
        }
        Console.WriteLine(promedioGeneral);
    }

    static public void notasTotalesAprobadas ()
    {
        for (int i = 0; i<10; i++)
        {
            Console.WriteLine(alumnosIngresados[i].nombreAlumno);
            alumnosIngresados[i].alumnosAprovados();
            Console.WriteLine("\n");
        }
    }

    static public void notasTotalesDesaprobadas ()
    {
        for (int i = 0; i<10; i++)
        {
            Console.WriteLine(alumnosIngresados[i].nombreAlumno);
            alumnosIngresados[i].alumnosDesaprovados();
            Console.WriteLine("\n");
        }
    }

    static string[] nombreAlumnos1 = new string [10];
    static int[,] notasAlumnos = new int[10,10];
   
    static Notas[] alumnosIngresados = new Notas[10];

    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido/a profesoro/a. A continuacion debe de ingresar 10 notas de 10 alumnos.");
        Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingresa el nombre del alumno: "); 
            nombreAlumnos1[i] = Console.ReadLine()!;

            int [] notasFinales = new int [10];
           
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Ingresa la nota número " + (j+1) + " de tu almuno: ");
                notasAlumnos[i,j] = ValidarNumero(Console.ReadLine()!);
                notasFinales[j] = notasAlumnos[i,j];
            }

            alumnosIngresados[i] = new Notas(notasFinales, nombreAlumnos1[i]);
        }

        Console.WriteLine("Ya has ingresado todas las notas de tus 10 alumnos. \nEs momento de elegir!");
        Console.WriteLine("------MENU-------\n1. Obtener Promedio Total\n2. Obtener notas aprobadas\n3. Obtener notas desaprovadas\n4. Finalizar Programa.");
        int opcionIngresadas = ValidarNumero(Console.ReadLine()!);

        switch(opcionIngresadas)
        {
            case 1: 
                promedioTotal();
            break; 

            case 2: 
                notasTotalesAprobadas();
            break; 

            case 3: 
                notasTotalesDesaprobadas();
            break; 

            case 4: 
                Console.WriteLine("El programa ha finalizado. Muchas gracias. Lindo día.");
            break; 
        }
       

    }

}
