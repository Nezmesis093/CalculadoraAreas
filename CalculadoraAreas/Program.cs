Console.WriteLine("Bienvenido a: Calculadoras de Areas .NET \n");
bool init = true;
do
{
    try
     {
        Console.WriteLine("Por favor, selecciona el numero con la figura a calcular su area:\n");
        Console.WriteLine("   1 - CUADRADO");
        Console.WriteLine("   2 - RECTANGULO");
        Console.WriteLine("   3 - TRIANGULO");
        Console.WriteLine("   4 - CIRCULO");
        Console.WriteLine("   5 - PENTAGONO");
        Console.WriteLine("   6 - SALIR DE CALCULADORA\n");

        int operacion = Convert.ToInt32(Console.ReadLine());

        if (operacion < 1 || operacion > 6)
        {
            Console.WriteLine("\nNo se selecciono una opción válida.");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("\n");
            continue;
        }
        if (operacion == 1)
        {
            Console.WriteLine("\n ¿Cúal es el valor del Lado A?");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Cúal es el valor del Lado B?");
            double valorB = Convert.ToDouble(Console.ReadLine());
            double total = 0.0;

            total = valorA * valorB;
            Console.WriteLine($"Resultado del area es = {total}");
            Console.WriteLine("\n");
        }
        else if (operacion == 2)
        {
            Console.WriteLine("\n ¿Cúal es el valor de la BASE?");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Cúal es el valor de la ALTURA?");
            double valorB = Convert.ToDouble(Console.ReadLine());
            double total = 0.0;

            total = valorA * valorB;
            Console.WriteLine($"Resultado del area es = {total}");
            Console.WriteLine("\n");
        }
        else if (operacion == 3)
        {
            Console.WriteLine("\n ¿Cúal es el valor de la BASE?");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Cúal es el valor de la ALTURA?");
            double valorB = Convert.ToDouble(Console.ReadLine());
            double total = 0.0;

            total = (valorA * valorB) / 2;
            Console.WriteLine($"Resultado del area es = {total}");
            Console.WriteLine("\n");
        }
        else if (operacion == 4)
        {
            Console.WriteLine("\n ¿Cúal es el valor del RADIO?");
            double valorA = Convert.ToDouble(Console.ReadLine());
            double total = 0.0;
            
            total = (valorA * valorA) * 3.1416;
            Console.WriteLine($"Resultado del area es = {total}");
            Console.WriteLine("\n");
        }
        else if (operacion == 5)
        {
            Console.WriteLine("\n ¿Cúal es el valor del PERIMETRO?");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Cúal es el valor de la APOTEMA?");
            double valorB = Convert.ToDouble(Console.ReadLine());
            double total = 0.0;
             
            total = (valorA * valorB) / 2;
            Console.WriteLine($"Resultado del area es = {total}");
            Console.WriteLine("\n");
        }
        else if (operacion == 6)
        {
            init = false;
            Console.WriteLine("\n");
            Console.WriteLine("Esta saliendo de... CALCULADORA DE AREAS, Gracias");
            continue;
        }

        Console.WriteLine("\n");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("\n");
    }
    catch
    {
        Console.WriteLine("\n");
        Console.WriteLine("Los datos ingresados no son los requeridos, favor de intentarlo de nuevo");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("\n");
    }

}
while (init == true);
Console.ReadKey();