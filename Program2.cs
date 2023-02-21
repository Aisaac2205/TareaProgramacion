byte num1, num2;
ushort resultado;

Console.Write("Ingrese un número de dos cifras: ");
num1 = byte.Parse(Console.ReadLine());

Console.Write("Ingrese otro número de dos cifras: ");
num2 = byte.Parse(Console.ReadLine());

resultado = (ushort)(num1 * num2);

Console.WriteLine(num1 + " x " + num2 + " = " + resultado);