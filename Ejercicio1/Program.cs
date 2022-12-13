using System;
namespace EJE0406
{
	class Ejercicio1
	{
		static void Main(string[] args)
		{
			int cantidadProductos;
			string[] productos;
			double[] precios;
			bool salida = false;

			//Petición de caintidad de productos a comprar
			Console.WriteLine("Introduzca la cantidad de productos que va a comprar");
			while (!Int32.TryParse(Console.ReadLine(), out cantidadProductos) || cantidadProductos > 0)
			{
				Console.WriteLine("Error! La cantidad de productos debe ser un número entero y mayor que 0");
			}

			//Inicialización de arrays
			productos = new string[cantidadProductos];
            precios = new double[cantidadProductos];


        }
	}
}