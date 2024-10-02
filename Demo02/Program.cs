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

//Console.WriteLine(SumarNaturales(3));

//2.- Crear una función sumar los primeros n números impares n=4
//1+3+5+7+....
int sumarNumerosImpares(int cantidad)
{
	int suma = 0;
	for (int i = 1; i <= cantidad; i++)
	{
		suma = suma + (2 * i - 1);
	}

	return suma;
}



//3.- Crear una función sumar los primeros n números pares n=4
//2+4+6+8+10
//2 * (1+2+3+4+...n)
int sumarPares(int cantidad)
{
	return 2 * SumarNaturales(cantidad);
}

//Mostrar en consola las 3 respuestas
Console.WriteLine(SumarNaturales(5)); // = 15
Console.WriteLine(sumarNumerosImpares(4)); // = 16
Console.WriteLine(sumarPares(4));	// = 20

Console.Read();