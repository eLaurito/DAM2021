//Ezequiel Laurito Nogueira 1º DAM Tema 4 Semana 2 Recomendado 71
/*Contabilidad doméstica (fragmento del examen del tema 4, grupo presencial, de 
 * 2013-2014)
Crea un programa en C# que pueda almacenar hasta 10000 gastos e ingresos, para 
* crear un pequeño sistema de contabilidad doméstica. Para cada gasto 
* (o ingreso), debe permitir guardar los siguientes datos:
- Fecha (8 caracteres: formato AAAAMMDD)
- Descripción del gasto o ingreso (por ejemplo, "Ampliación de RAM para el 
* ordenador")
- Categoría (por ejemplo, "estudios")
- Importe (positivo si es un ingreso, negativo si es un gasto)
El programa debe permitir al usuario realizar las siguientes operaciones:
1- Añadir un nuevo gasto (o ingreso; la fecha debe "parecer correcta": día de 
* 01 a 31, mes de 01 a 12, año entre 1000 y 3000, y se volverá a pedir si no es
*  así). La descripción no debe estar vacía. No hace falta validar los demás 
* datos.
2- Mostrar todos los gastos (o ingresos) de una cierta categoría (por ejemplo, 
* "estudios"). Al final de todos los datos se mostrará el importe total de los 
* datos mostrados. Se mostrarán todos los datos de cada gasto, en una misma 
* línea.
3- Buscar gastos (o ingresos) cuya descripción sea la que introduzca el usuario.
4- Modificar una ficha (pedirá el número de ficha al usuario; se mostrará el 
* valor anterior de cada campo y se podrá pulsar Intro para no modificar alguno 
* de los datos). Se debe avisar (pero no volver a pedir) si el usuario introduce
*  un número de ficha incorrecto. No hace falta validar ningún dato.
5- Borrar un cierto dato, a partir del número de registro que indique el 
* usuario. Se debe avisar (pero no volver a pedir) si introduce un número 
* incorrecto. Se debe mostrar la ficha que se va a borrar y pedir confirmación
*  antes de proceder al borrado.
T- Terminar el uso de la aplicación (como no sabemos almacenar la información, 
* los datos se perderán)
*/
using System;
public class T4s2
{
    const int MAXIMO = 10000;
    
    
    struct tipoIngreso
    {
            public string fecha;
            public string descripcion;
            public string categoria;
            public int importe;
    }
    
    public static void Main()
    {
    
        tipoIngreso[] contabilidad = new tipoIngreso[MAXIMO];
        bool terminado = false;
        char opcion = ' ';
        int contador = 0;
            
        do
        {
            
            Console.WriteLine("1- Añadir operación. ");
            Console.WriteLine("2- Buscar gasto por categoria");
            Console.WriteLine("3- Buscar gasto por descripción");
            Console.WriteLine("4- Modificar una ficha");
            Console.WriteLine("5- Borrar ficha");
            Console.WriteLine("T- Terminar el uso de la aplicación");
            Console.WriteLine();
            
            opcion = Convert.ToChar(Console.ReadLine());
            
            switch(opcion)
            {
                case '1':  //Añadir un nuevo gasto o ingreso
                {                
                    
                    do
                    {
                        Console.WriteLine("Ingresar fecha (AAAAMMDD)");
                        contabilidad[contador].fecha = Console.ReadLine();
                    }while(contabilidad[contador].fecha == "");
                    
                    do
                    {
                        Console.WriteLine("Ingresar descripción: ");
                        contabilidad[contador].descripcion = Console.ReadLine();
                    }while(contabilidad[contador].descripcion == "");
                    
                    Console.WriteLine("Ingresar categoría: ");
                    contabilidad[contador].categoria = Console.ReadLine();
                    
                    Console.WriteLine("Ingresar importe: ");
                    contabilidad[contador].importe = 
                        Convert.ToInt32(Console.ReadLine());
                    
                    contador++;
                    Console.WriteLine();
                    break;
                }
                
                case '2':  //Mostrar todos los g/i de una categoría
                {
                    Console.Write("Elige una categoría:");
                    string categoria = Console.ReadLine();
                    bool encontrado = false;
                    
                    for(int i = 0; i < contador; i++)
                        {
                            if(categoria == contabilidad[i].categoria)
                               {
                                   Console.WriteLine("({0})-{1}-{2}-{3}€", 
                                   i + 1, contabilidad[i].fecha,
                                   contabilidad[i].descripcion, 
                                   contabilidad[i].importe); 
                                   
                                   encontrado = true;
                                }
                        }
                        
                    if (! encontrado) 
                        Console.WriteLine("No existe registro");
                        
                    Console.WriteLine();
                    break;
                }
                
                case '3': // Buscar g/i con descripcion
                {
                    Console.Write("Descripción a buscar? ");
                    string descripcion = Console.ReadLine();
                    
                    for(int i = 0; i < contador; i++)
                    {
                        if(descripcion == contabilidad[i].descripcion)
                               Console.WriteLine("({0})-{1}-{2}-{3}€", 
                               i + 1, contabilidad[i].fecha,
                               contabilidad[i].categoria, 
                               contabilidad[i].importe); 
                    }
                    
                    Console.WriteLine();
                    break;
                }
                
                case '4': //Modificar una ficha
                {
                    Console.WriteLine("Elige ficha: ");
                    int ficha = Convert.ToInt32(Console.ReadLine());
                    ficha--;
                    string nuevoCampo = " ";
                    
                    if(ficha >= 0 && ficha <= contador)
                    {
                        Console.WriteLine("Fecha: '{0}' * modificar?", 
                            contabilidad[ficha].fecha);  
            
                        nuevoCampo = Console.ReadLine();
                        if(nuevoCampo != "")
                            contabilidad[ficha].fecha = nuevoCampo;
                        
                        Console.WriteLine("descripción: '{0}' * modificar?", 
                            contabilidad[ficha].descripcion);  
                        
                        nuevoCampo = Console.ReadLine();
                        if(nuevoCampo != "")
                            contabilidad[ficha].descripcion = nuevoCampo;
                            
                        Console.WriteLine("categoria: '{0}' * modificar?", 
                            contabilidad[ficha].categoria);  
                        
                        nuevoCampo = Console.ReadLine();
                        if(nuevoCampo != "")
                            contabilidad[ficha].categoria = nuevoCampo;
                        
                        Console.WriteLine("Importe: '{0}' * modificar?", 
                            contabilidad[ficha].importe);  
                        
                        nuevoCampo = Console.ReadLine();
                        if(nuevoCampo != "")
                            contabilidad[ficha].importe = 
                                Convert.ToInt32(nuevoCampo);
                    }
                    else
                        Console.Write("Ficha incorrecta");
                        
                    Console.WriteLine();
                    break;
                }
                
                case '5': //Borrar un cierto dato
                {
                    Console.WriteLine("Elije una ficha: ");
                    int ficha = Convert.ToInt32(Console.ReadLine());
                    
                    if(ficha >= 0 && ficha <= contador)
                    {
                        for(int i = (ficha - 1); i < contador; i++)
                        { 
                            contabilidad[i].fecha = contabilidad[i + 1].fecha;
                            contabilidad[i].descripcion = 
                                contabilidad[i + 1].descripcion;
                            contabilidad[i].categoria = 
                                contabilidad[i + 1].categoria;
                            contabilidad[i].importe = contabilidad[i + 1].importe;
                        }
                        
                        contabilidad[contador].fecha = "";
                        contabilidad[contador].descripcion = "";
                        contabilidad[contador].categoria = "";
                        contabilidad[contador].importe = 0;
                        contador --;
                    
                        Console.WriteLine("Registro {0} borrado", ficha);
                    }
                    else
                        Console.WriteLine("Ficha incorrecta");
                    
                    Console.WriteLine();
                    break;    
                }
                
                case 'T':
                {
                    terminado = true;
                    break;
                }
            }
        }while(!terminado);
        
    }//end Main()
}
