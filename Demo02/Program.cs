// See https://aka.ms/new-console-template for more information
//BUCLES

//1.- Crear una función que sume los primeros n números naturales
//1+2+3+4+5...

int SumarNaturales(int cantidad)
{
	//Acumulador
	int suma = 0;
	for (int i = 1; i <= cantidad; i++)
	{
		suma = suma + i;
	}
	return suma;
}
//Console.WriteLine(SumarNaturales(5)); // = 15

//2.- Crear una función sumar los primeros n números impares n=4
//1+3+5+7+....
int sumarNumerosImpares(int cantidad)
{
	int suma = 0;
	//int impar = 0;
	for (int i = 1; i <= cantidad; i++)
	{
		//impar = 2 * i + 1;
		suma = suma + (2 * i - 1);
		//Console.WriteLine("Impar:");
		//Console.WriteLine(impar);

		//suma = suma + impar;
	}

	return suma;
}
//Console.WriteLine(sumarNumerosImpares(4)); // = 16

//3.- Crear una función sumar los primeros n números pares n=4
//2+4+6+8+10
//2 * (1+2+3+4+...n)
int sumarPares(int cantidad)
{
	return 2 * SumarNaturales(cantidad);
}
//Console.WriteLine(sumarPares(4));	// = 20

//4.- Crear una tabla de multiplicar usando Do While.
void crearTablaMultiplicar(int numero)
{
	int cantidad = 12;
	int i = 1;
    Console.WriteLine("La tabla de multiplicar del número " + numero + ":");

    while (i <= 12)
	{
		Console.WriteLine(numero + " x " + i + " = "+numero * i);
		i = i + 1;
	}
}
//crearTablaMultiplicar(5);

//5.- Crear una función usando WHILE sumar los números cuadrados n = 5
//1^2 = 1
//2^2 = 4
//3^2 = 9
//4^2 = 16
//5^2 = 25
int sumarCuadrados(int cantidad)
{
	int suma = 0;
	int i = 1;

	while (i <= cantidad)
	{
		suma = suma + (i * i);
		i++;
    }

	return suma;
}
//Otra forma:
/*
int sumarCuadrados(int cantidad)
{
    int i = 1;
	int suma = 0;
	int cuadrado = 0;

    while (i <= cantidad)
    {
		cuadrado = i * i;
		Console.WriteLine("cuadrado");
		Console.WriteLine("cuadrado");
        suma = suma + cuadrado;
        i++;
    }
    return suma;
}
*/
//Console.WriteLine(sumarCuadrados(4)); // = 30

//6.- Crear una tabla de multiplicar al reves, utilizar un PROCEDIMIENTO.
void crearTablaMultiplicarReves(int numero)
{
    int i = 12;
    Console.WriteLine("La tabla de multiplicar del número " + numero + ":");

    while (i > 0 )
    {
        Console.WriteLine(numero + " x " + i + " = " + numero * i);
        i--;
		//i = i - 1;
		
    }
}
crearTablaMultiplicarReves(5);


Console.Read();