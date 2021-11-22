//Ezequiel Laurito Nogueira 1º DAM Tema 4 Semana 2 Recomendado 69
// Crea un "struct" para almacenar algunos datos de juegos de ordenador o 
//consola, de momento sólo: título (cadena de texto), plataforma (cadena de 
//texto), espacio ocupado (en MB, número entero) y fecha de lanzamiento (mes y 
//año, en forma de struct anidado). Pide al usuario datos de 3 juegos (que 
//serán parte de un array) y luego muéstralos.
using System;
public class T4s2
{
    const int MAXIMO = 2;
    
    struct tipoFecha
    {
        public int mes;
        public int anyo;
    }
    
    struct tipoJuego
    {
            public string titulo;
            public string plataforma;
            public int espacio;
            public tipoFecha fecha;
    }
    public static void Main()
    {
        tipoJuego[] coleccion = new tipoJuego[MAXIMO];
        
        for(int i = 0; i < coleccion.Length; i++)
        {
            Console.Write("Juego {0} nombre: ", i + 1);  
            coleccion[i].titulo = Console.ReadLine();  
            
            Console.Write("Juego {0} plataforma: ", i + 1);
            coleccion[i].plataforma = Console.ReadLine();
            
            Console.Write("Juego {0} espacio(en mb): ", i + 1);
            coleccion[i].espacio = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Juego {0} mes de lanzamiento: ", i + 1);
            coleccion[i].fecha.mes = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Juego {0} año de lanzamiento: ", i + 1);
            coleccion[i].fecha.anyo = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
        }
        
        for(int i = 0; i < coleccion.Length; i++)
        {
            Console.WriteLine();
            Console.Write("Juego {0}: {1}({2}mb) ", 
                        i + 1, coleccion[i].titulo, coleccion[i].espacio);
            Console.Write("para {0}({1}/{2})", 
                coleccion[i].plataforma, coleccion[i].fecha.mes,
                coleccion[i].fecha.anyo);
        }
        
    }
}
