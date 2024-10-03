// Bucle Do While
int valor = 0;

do
{
    valor++;
    Console.WriteLine(valor);

}while(valor<12);

//1.- Pedir un número por consola
int numero1, numero2;
Console.Write("Ingresa el primer número: ");

//Convert es una clase propia de .NET, presionando F12 se puede verificar.
numero1 = Convert.ToInt32(Console.ReadLine());

//Conversión nativa
//numero2 = int.Parse(Console.ReadLine());

Console.Write("Ingresa el segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());


Console.Write("La suma de los números es:");
Console.WriteLine(numero1 + numero2);

//2.- Leer un número mediante un procedimiento
void leerNumeroPositivo()
{
    int numero = 0;
    do
    {
        Console.Write("Ingresa un número positivo: ");
        numero = Convert.ToInt32(Console.ReadLine());

    } while (numero <= 0);

    Console.WriteLine("Ha ingresado un número positivo: " + numero);
}
leerNumeroPositivo();

/*3.- Pedir las notas de 0 - 20. Si ingresa una nota en ese rango, debe mostrarse el mensaje
su nota es. Pero, si ingresa nota fuera del rango, debe volver a pedir nuevamente la nota.
Utilizar Procedimiento.
*/
void leerNota()
{
    int numero = 0;
    do
    {
        Console.Write("Ingresa un número entre 0 - 20: ");
        numero = Convert.ToInt32(Console.ReadLine());

    } while (numero < 0 || numero > 20);

    Console.WriteLine("Tu nota es: " + numero);
}
leerNota();

Console.Read();