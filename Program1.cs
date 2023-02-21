long num1, num2, suma, resta, producto;


Console.Write("Ingrese un número entero de 2 o más cifras: ");
num1 = long.Parse(Console.ReadLine());

Console.Write("Ingrese otro número entero de 2 o más cifras: ");
num2 = long.Parse(Console.ReadLine());

suma = num1 + num2;
resta = num1 - num2;
producto = num1 * num2;

Console.WriteLine(num1 + " + " + num2 + " = " + suma);
Console.WriteLine(num1 + " - " + num2 + " = " + resta);
Console.WriteLine(num1 + " x " + num2 + " = " + producto);
