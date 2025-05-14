using System.Runtime.InteropServices;

class program
{
    static void Main(string[] args)
    {
        //Ejercicio2();
        practica();
    }
    static void Ejercicio1()
    {
        Random random = new Random();
        List<int> lista_num = new List<int>();

        int numero;

        while (true)
        {
            numero = random.Next(1, 101);
            if (numero < 98)
            {
                lista_num.Add(numero);
            }
            else
            {
                break;
            }

        }

        foreach (int i in lista_num)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        int numeroMax = lista_num.Max();
        Console.WriteLine("El numero maximo es: " + numeroMax);
    }
    static void Ejercicio2()
    {
        int contador = 0;
        double suma = 0;
        List<double> lista_tiempo = new List<double>();
        while (true)
        {
            Console.WriteLine($"Ingrese la temperatura del dia {contador + 1}");
            string dia = Console.ReadLine();
            bool diaa = double.TryParse(dia ,out double var);

            if (!diaa)
            {
                Console.WriteLine("Error, ingrese valores validos");
                continue;
            }
            contador++;
            if (contador == 7)
            {
                break;
            }
            lista_tiempo.Add(var);
            suma += var;
        }
        double promedio = lista_tiempo.Average();
        int mayor = 0;
        int menor = 0;
        for (int i = 0; i < lista_tiempo.Count; i++)
        {
            if (lista_tiempo[i] > promedio)
            {
                mayor++;
            }
            else
            {
                menor++;
            }
        }
        Console.WriteLine($"Cantidad de dia con mayor que el promedio: {mayor}");
        Console.WriteLine($"Cantidad de dia con menor que el promedio: {menor}");
        Console.WriteLine($"El promedio de las temperaturas es de {promedio}%");
    }
}