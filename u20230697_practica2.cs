using System;
using System.Data;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            // DECLARACIONDE VARIABLES TIPO STRING CAPTURANDO DESDE LA TERMINAL

            string? nombre;
            string? apellido;

            // DECLARACION DE VARIABLES DE TEXTO DESDE CODIGO

            string? codigo = "u20230697";
            string? becado = "no";

            // DECLRACION DE VARIABLES DE TIPO ENTERAS CAPTURANDO DESDE LA TERMINAL

            int edad;

            // DECLRACION DE VARIABLES DE TIPO ENTERO DESDE CODIGO

            int ingreso = 2023;
            int egreso = 2024;

            // DECLARACION DE VARIABLES DE TIPO DOUBLE DESDE LA TERMINAL

            double mensualidad;

            // DECLARACION DE VARIABLES DECIMALES DESDE CODIGO

            double transporte = 2.00;
            double alimento = 3.50;

            // DECLARACION DE VARIABLES DE TIEMPO 

            DateTime fechaactual = DateTime.Now;
            DateTime fechaespecifica = new DateTime(2023, 8, 20, 16,20,00);


            // OPTENCION DE DATOS DESDE LA TERMINAL

            Console.WriteLine("ingrese su nombre");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("ingrese su apellido");
            apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("ingrese su edad");
            edad = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("ingrese su mensualidad");
            mensualidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // IMPRESION DE DATOS

            Console.WriteLine("su nombre es: " + nombre);
            Console.WriteLine("su apellido es: " +  apellido);
            Console.WriteLine("su codigo es: " + codigo);
            Console.WriteLine("es becado?: " + becado);
            Console.WriteLine("su edad es: " + edad);
            Console.WriteLine("su ingreso fue: " + ingreso);
            Console.WriteLine("su egreso sera: " + egreso);
            Console.WriteLine("su mensualidad de la u es: " + "$" + mensualidad);
            Console.WriteLine("su gasdo de transporte es: " + "$" + transporte);
            Console.WriteLine("su gasto de alimento es:  " + "$" + alimento);
            Console.WriteLine("la fecha y tiempo es: " + fechaactual);
            Console.WriteLine("la fecha que termina la practica es: " + fechaespecifica);
            Console.WriteLine("-------------------fin proceso-----------------");

            Console.WriteLine("-------------------inicio-----------------");

            //APLIACION DE FUNCIONES DE TAREA

            // FUNCION DE COMPARACION CADENAS DE TEXTO
            bool cadenacomparativa = nombre == apellido;

            // FUNCION DE MINUSCULA
            string?  funcionminuscula1 = nombre.ToLower();
            string?  funcionminuscula2 = apellido.ToLower();

            // FUNCION DE MAYUSCULA
            string?  funcionmayuscula1 = nombre.ToUpper();
            string?  funcionmayuscula2 = apellido.ToUpper();

            // FUNCION CON COCATENADO
            string?  cadenaconcatenado = nombre + " " + apellido;

            // FUNCION DE TAMAÑO DE CADENA
            int longitudcadena1 = nombre.Length;
            int longitudcadena2 = apellido.Length;
            
            Console.WriteLine("comparacio: " + cadenacomparativa);
            Console.WriteLine("minuscula nombre y apellido: " + funcionminuscula1 + " " + funcionminuscula2);
            Console.WriteLine("mayuscula nombre y apellido: " + funcionmayuscula1 + " " + funcionmayuscula2);
            Console.WriteLine("concatenacion: " + cadenaconcatenado);
            Console.WriteLine("la longitud de el nombre es: " + longitudcadena1);
            Console.WriteLine("la longitud de el apellido es: " + longitudcadena2);
            Console.WriteLine("-------------------------------fin proceso----------------------");

            // NOMBRE: Pedro Antonio Alvarez Hernandez
            // CODIGO: u20230697           
        }
    }
}