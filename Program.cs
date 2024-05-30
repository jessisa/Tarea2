// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.VisualBasic;
using System.Collections;

//comentario jessica 29/05/2024

#region ejercicio01   
static void convertirnumero(string cad)
{

    if (cad == "1" || cad == "2" || cad == "3" || cad == "4" || cad == "5" || cad == "6" || cad == "7" || cad == "8" || cad == "9" || cad == "0")
    {
        int dou = 0;
        dou = int.Parse(cad);

    
        Console.WriteLine($"El número es:{dou}");
    }
    else
    {
        throw new FormatException("Solo se aceptan números");
    }


}

try
{

    convertirnumero("a");
}
catch (FormatException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
#endregion

#region ejercicio02
static void dividirnumeros(int num1, int num2)
{
    if (num1 < 0 || num2 < 0)
    {

        throw new ArgumentException("No se pueden dividir números negativos.");
    }


    int resultado = num1 / num2;
    Console.WriteLine("El resultado de la división es: " + resultado);

}

try
{

    dividirnumeros(10, -5);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
#endregion


