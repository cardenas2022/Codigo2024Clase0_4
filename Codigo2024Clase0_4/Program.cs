// See https://aka.ms/new-console-template for more information
//CLASE 09/09/24

//FUNCIONES: devuelven un valor.
int Sumar(int a, int b)
{
    return a + b;
}

//PROCEDIMIENTOS: ejecutan sentencias.
void Restar(int a, int b)
{
    Console.WriteLine(a - b);
}

//HALLAR LA BASE Y ALTURA DE UN RECTÁNGULO
//FORMA 1 - CALCULAR BASE Y ALTURA DE UN RECTÁNGULO
double CalcularDistancia(double x1, double y1, double x2, double y2)
{
    double valor1 = Math.Pow((x2 - x1), 2);
    double valor2 = Math.Pow((y2 - y1), 2);
    double distancia = Math.Sqrt(valor1 + valor2);

    return distancia;
}



//FORMA 2 - CALCULAR BASE Y ALTURA DE UN RECTÁNGULO

/*void CalcularBase(int x1, int y1, int x2, int y2)
{
    double valor1 = Math.Pow((x2 - x1), 2);
    double valor2 = Math.Pow((y2 - y1), 2);
    double base1 = Math.Sqrt(valor1 + valor2);
    Console.WriteLine("La base es: ");
    Console.WriteLine(base1);
}

void CalcularAltura(int x2, int y2, int x3, int y3)
{
    double valor1 = Math.Pow((x3 - x2), 2);
    double valor2 = Math.Pow((y3 - y2), 2);
    double altura = Math.Sqrt(valor1 + valor2);
    Console.WriteLine("La altura es: ");
    Console.WriteLine(altura);
}
*/

/*
CalcularBase(0,0,4,0);
CalcularAltura(4, 0, 4, 6);
*/

double x1 = 0;
double y1 = 0;
double x2 = 4;
double y2 = 0;
double x3 = 4;
double y3 = 6;
double x4 = 0;
double y4 = 6;

double base1 = CalcularDistancia(x1, y1, x2, y2);
Console.WriteLine("La base es: ");
Console.WriteLine(base1);

double altura = CalcularDistancia(x2, y2, x3, y3);
Console.WriteLine("La altura es: ");
Console.WriteLine(altura);

//EJERCICIO:
//1. Calcular el área de un rectángulo
//2. Calcular el perímetro de un rectángulo
double CalcularAreaRectangulo(double bas, double alt)
{
    double area = bas * alt;

    return area;
}

double CalcularPerimetroRectangulo(double bas, double alt)
{
    double perimetro = (bas + alt)*2;

    return perimetro;
}

double bas = 4;
double alt = 6;

double area = CalcularAreaRectangulo(bas, alt);
Console.WriteLine("El área es: ");
Console.WriteLine(area);

double perimetro = CalcularPerimetroRectangulo(bas, alt);
Console.WriteLine("El perímetro es: ");
Console.WriteLine(perimetro);

Console.Read();