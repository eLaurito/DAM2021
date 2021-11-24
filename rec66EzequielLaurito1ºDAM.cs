//Ezequiel Laurito Nogueira 1º DAM Tema 4 Semana 2 Recomendado 66
// Crea un programa que pida al usuario 12 números reales de simple precisión, 
//los guarde en una matriz bidimensional de 2x5 datos, y luego muestre el 
//promedio de los valores que hay guardados en la primera mitad de la matriz, 
//luego el promedio de los valores en la segunda mitad de la matriz y finalmente 
//el promedio global.
using System;
public class T4s2
{
    public static void Main()
    {
        float[,] matrizz = new float [2,6];
        float promedio = 0, promedioTotal = 0;

        for(int i = 0; i < matrizz.GetLength(0); i++)
        {
            for(int j = 0; j < matrizz.GetLength(1); j++)
            {
                Console.WriteLine("pos {0}-{1} número?",i+1,j+1);
                matrizz[i,j] = Convert.ToSingle(Console.ReadLine());
                promedio += matrizz[i,j];
                promedioTotal += matrizz[i,j];
            }
            Console.WriteLine("Promedio de la mitad {0} de la matriz: {1}",
                                i + 1, promedio / 5);
            promedio = 0;
        }
        
        Console.WriteLine("Promedio total: {0}", 
            promedioTotal / (matrizz.GetLength(1) * matrizz.GetLength(0)) );

    }
}
