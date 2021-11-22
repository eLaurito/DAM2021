//Ezequiel Laurito Nogueira 1º DAM Tema 4 Semana 2 Recomendado 67
// Crea una variante del programa anterior, que pregunte al usuario cuántos 
//datos guardará en un primer bloque de números reales de simple precisión, 
//luego cuántos datos guardará en un segundo bloque, y finalmente pida los 
//datos en sí. Los debe guardar en un array de arrays. Después mostrará el 
//promedio de los valores que hay guardados en el primer subarray, luego el 
//promedio de los valores en el segundo subarray y finalmente el promedio global
using System;
public class T4s2
{
    public static void Main()
    {
        double[][] arraiz;
        double promedio = 0, promedioTotal = 0;
        int sumaLenght = 0;
        
        Console.WriteLine("Cantidad de arrays? ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("tamaño de arrays? ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        arraiz = new double[num1][];
        for(int i = 0; i < arraiz.Length; i++)
            arraiz[i] = new double[num2];
        
        for(int i = 0; i < arraiz.Length; i++)
        {
            for(int j = 0; j < arraiz[i].Length; j++)
            {
                Console.WriteLine("Posición {0}-{1} Número? ",
                                    i + 1, j + 1);
                arraiz[i][j] = Convert.ToDouble(Console.ReadLine());
                
                promedio += arraiz[i][j];
                promedioTotal += arraiz[i][j];
                sumaLenght++;
            }
            
            Console.WriteLine();
            Console.WriteLine("Promedio del array {0} es: {1}",
                                i + 1, promedio / arraiz[i].Length); 
            promedio = 0;
            
        }
                
            Console.WriteLine("Promedio total es: {0}",
                                promedioTotal / sumaLenght);         
        
    }
}
