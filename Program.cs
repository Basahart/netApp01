using System;

namespace ES172003671
{
    class estudianteUniversitario
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("|       Registro de datos Estudiante Universitario       |");
            Console.WriteLine("==========================================================\n");
            Console.WriteLine("Por favor, ingresa tus datos.\n");
           
            // Solicitud de datos
            Console.Write("Ingresa tu nombre(s): ");
            string nombre = Console.ReadLine();
            
            Console.Write("Ingresa tu apellido paterno: ");
            string apellidoPaterno = Console.ReadLine();
            
            Console.Write("Ingresa tu apellido materno: ");
            string apellidoMaterno = Console.ReadLine();
            
            Console.Write("Ingresa tu año de nacimiento a 4 dígitos(ej. 1990): ");
            int anioNacimiento = int.Parse(Console.ReadLine());
            
            Console.Write("Ingresa la carrera que estudias: ");
            string carrera = Console.ReadLine();
            
            Console.Write("Ingresa tu promedio general: ");
            double promedio = double.Parse(Console.ReadLine());
            
            Console.Write("Ingresa el número de materias inscritas: ");
            int materiasInscritas = int.Parse(Console.ReadLine());
            
            // Lógica del programa 

            // Cálculo - Edad actual del estudiante (basada en el año de nacimiento)
            int anioActual = DateTime.Now.Year;
            int edadActual = anioActual - anioNacimiento;
            
            // cantidad total de horas de estudio semanales (4 horas por materia).
            int horasEstudioSemanales = materiasInscritas * 4;

            // Reorganización del nombre del estudiante.
            string nombreReorganizado = apellidoPaterno + " " + apellidoMaterno + " " + nombre;
            
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Presentación de datos en pantalla
            Console.WriteLine("\n==========================================================");
            Console.WriteLine("|               Información de Estudiante                |");
            Console.WriteLine("==========================================================\n");
            
            Console.WriteLine("Nombre: " + nombreReorganizado);
            Console.WriteLine("Edad actual: " + edadActual + " años");
            Console.WriteLine("Carrera en curso: " + carrera);
            Console.WriteLine("Promedio general: " + promedio);
            Console.WriteLine("Materias inscritas: " + materiasInscritas);
            Console.WriteLine("Horas de estudio semanales: " + horasEstudioSemanales + " horas");
            Console.WriteLine("==========================================================\n");
            
            // Pausar consola para visualizar resultados*/
            Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}

