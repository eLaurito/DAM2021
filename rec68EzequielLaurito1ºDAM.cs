//Ezequiel Laurito Nogueira 1º DAM Tema 4 Semana 2 Recomendado 68
//Crea un "struct" para almacenar algunos datos de juegos de ordenador o 
//consola, de momento sólo: título (cadena de texto), espacio ocupado 
//(en MB, número entero). Pide al usuario datos de 3 juegos (que serán parte 
//de un array) y luego muéstralos.
using System;
public class T4s2
{
    const int MAXIMO = 3;
    
    struct tipoJuego
    {
        public string titulo;
        public int espacio;
        
    }    
    
    public static void Main()
    {
        tipoJuego[] coleccion = new tipoJuego[MAXIMO];
        
        for(int i = 0; i < coleccion.Length; i++)
        {
            Console.WriteLine("Juego {0} -  Nombre: ", i+1);
            coleccion[i].titulo = Console.ReadLine();
            
            Console.WriteLine("Juego {0} -  Espacio ocupado(en MB): ", i+1);
            coleccion[i].espacio = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
        }
        
        for(int i = 0; i < coleccion.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Juego {0}: {1}({2}mb)", 
                        i + 1, coleccion[i].titulo, coleccion[i].espacio);

        }
        
    }
}
