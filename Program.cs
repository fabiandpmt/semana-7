using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_7
{
    internal class Program
    {
        static int max = 100;
        static string[] nombres = new string[max];
        static double[] notas=new double[max];
        static int contador=0;
        static public void Titulo()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Sistema de Gestión de notas");
            Console.WriteLine("**********************");
        }
        static public void Registrar_estudiante() 
        {
            Console.WriteLine("Registro de Estudiante Nuevo: ");
            if (contador >= 100)
            {
                Console.WriteLine("Alcanzo la Capacidad Máxima: ");
                return;
            }
            Console.WriteLine("Ingresar nombre del Estudiante: ");
            string nombre= Console.ReadLine();
            double nota;
            while (true) 
            {
                Console.Write("Ingresar Nota[0-20]: ");
                nota=double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 20)
                {
                    break;
                }
                Console.WriteLine("Error, Volver a ingresar la nota [0-20]");
            }
            nombres[contador] = nombre;
            notas[contador]= nota;
            contador++;
            Console.WriteLine("Registro con Exitoso..!!");
        }
        static public void buscar_estudiante();
        {
        }
        static void Main(string[] args)
        {
        }
    }
}
