using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Deber3
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int ban = 0;
            //Creacion de los 50 números
             int[] numeros = new int[50]{ 90, 87, 33, 1, 24, 24, 29, 27, 72, 59, 49, 87, 14, 92, 87, 95, 64,
                                         44, 94, 47, 24 ,95, 6, 47, 30, 13, 14 ,55 ,98, 15, 64 ,75, 0, 22,
                                         23, 77, 3 ,38, 99, 42, 39, 74, 29, 74, 15, 57, 39, 24, 51, 64 };
            while (ban == 0)
            {
                Console.WriteLine("<<<<<<<<<<<<Menu>>>>>>>>");
            Console.WriteLine("1) Mostrar por consola todos los números primos \n"+
                              "2)• Mostrar por consola la suma de todos los elementos\n" +
                              "3)Generar una nueva lista con el cuadrado de los números.\n"+
                              "4)Generar una nueva lista con los números que no son primos.\n" +
                              "5)Obtener el promedio de todos los números mayores a 50.\n" +
                              "6)Contar en la lista la cantidad de números pares e impares.\n" +
                              "7)Mostrar por consola cada elemento y la cantidad de veces que se repite en la lista.\n" +
                              "8)Mostrar en consola los elementos de forma descendente.\n" +
                              "9) Mostrar en consola los números únicos(no se repiten).\n" +
                              "10)Sumar todos los números únicos de la lista.\n" );
                               op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    //Inicio1
                    var consulta1 = from numero in numeros
                                    where (numero % 2) != 0
                                    select numero;

                    foreach (var item1 in consulta1)
                    {
                        Console.Write("|{0}| ", item1);
                    }
                    //Fin1
                }
                else
                    if (op == 2)
                {
                    //INICIO DE PUNTO 2
                    var consulta2 = from Nume in numeros
                                    select Nume;
                    Console.WriteLine("La Suma Total es   {0}", consulta2.Sum());
                    //FIN DE PUNTO 2
                }
                else
                    if (op == 3)
                {
                    //INICIO DE PUNTO 3
                    Console.WriteLine("CUADRADOS DE LOS NUMEROS");
                    var consulta3 = from Nume in numeros

                                    select Nume;
                    foreach (var item in consulta3)
                    {

                        Console.WriteLine(item * item);
                    }

                    //Fin del punto 3
                }
                else
                    if (op == 4)
                {





                }
                else
                    if (op == 5)
                {  //INICIO DE PUNTO 5
                   //Creador de Consultar dato
                    var consulta5 = from Nume in numeros
                                        //Consulta los numeros mayores a 50 
                                    where Nume > 50
                                    select Nume;
                    //Muestra EL PROMEDIO DE LOS NUMEROS MAYORES A 50
                    Console.WriteLine("El promedio es {0}", consulta5.Average());
                    //FIN DE PUNTO 5
                }
                else
                    if (op == 6)
                {
                    //INICIO 6
                    int c = 0;
                    int d = 0;

                    var consulta6 = from Nume in numeros
                                    group Nume by (Nume % 2) == 0 ? c++ : d++;

                    //Coregir
                    foreach (var item in consulta6)
                    {

                        Console.WriteLine(" pares  {0}" + "impares {1}", c,d);

                    } 
                    //FIN 6

                }
                else
                    if (op == 7)
                {
                    //INCIO 7
                    foreach (var registro in
                numeros.Select((v) => new {  Valor = v }) // Obtener  valor
                .GroupBy(x => x.Valor) // Agrupar por el valor
              //.Where(x => x.ToList().Count() > 1) // En caso necesitas obtener cant. repetidas mayor a 1
                .Select(x => new {
                    Valor = x.Key, // key de la agrupación (valor)
                    Cantidad = x.Count(), // Cantidad de duplicidad
                }))
                    {
                        Console.WriteLine(string.Format("Valor: '{0}'\tCant. Repetidas: {1}\t", registro.Valor, registro.Cantidad));
                    }
                    //FIN 7
                }
                else
                    if (op == 8)
                {
                    //INICIO DE PUNTO 8
                    Console.WriteLine("NUMEROS ORDENADOS EN FORMA DESCENDENTES");
                    var consulta8 = from Nume in numeros
                       //aqui se pide para ordenar los datos en orden descendentes
                                    orderby Nume descending
                                    select Nume;
                    //Mostar Datos en orden  descendentes
                    foreach (var item in consulta8)
                    {
                        Console.WriteLine(item);
                    }
                    //FIN DE PUNTO 8 */
                }
                else 
                    if(op==9)
                {
                    //"9) Mostrar en consola los números únicos(no se repiten).\n" +
                    //inicio
                    foreach (var registro in
   numeros.Select((v) => new { Valor = v }) // Obtener  valor
   .GroupBy(x => x.Valor) // Agrupar por el valor
   .Select(x => new {
       Valor = x.Key, // key de la agrupación (valor)
                    
                }))
                    {
                        Console.WriteLine(string.Format("Valor: '{0}\t", registro.Valor));
                    }
                    //FIN 9
                }
                else
                    if(op==10)
                {
                    //inicio
                    //"10)Sumar todos los números únicos de la lista.\n"
                    int suma = 0;
                    foreach (var registro in
             numeros.Select((v) => new { Valor = v, Valor2=0}) // Obtener  valor
             .GroupBy(x => x.Valor) // Agrupar por el valor
                                   
             .Select(x => new {
                 Valor = x.Key, // key de la agrupación (valor)
                }))
                    {
                        suma = suma + registro.Valor;
                    }
                    {
                        Console.WriteLine("La suma total es "+suma);
                    }
                    //FIN 10
                }
                else
                    Console.WriteLine("No Valid0");

                    Console.WriteLine("Desea Regresar al menu ");
                Console.WriteLine("Ingrese  0  o 1 para salir  ");
                int a = int.Parse(Console.ReadLine());
                ban = a;
            }
            Console.WriteLine("GRACIAS POR SU VISITA");
            Console.ReadLine();
        }      
    }
}