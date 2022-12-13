using System;
namespace EJE0406
{
	class Ejercicio1
	{
		static void Main(string[] args)
		{
			int productosRegalados = 0;
			int cantidadProductos = 0;
			int posicionPrecioMenor = 0;

			string[] productos;
			double[] precios;
			double[] nuevosPrecios; 
			double precioMenor = 0;
			bool salida = false;

			//Petición de caintidad de productos a comprar
			Console.WriteLine("Introduzca la cantidad de productos que va a comprar");
			while (!Int32.TryParse(Console.ReadLine(), out cantidadProductos) || cantidadProductos <= 0)
			{
				Console.WriteLine("Error! La cantidad de productos debe ser un número entero y mayor que 0");
			}

			//Inicialización de arrays
			productos = new string[cantidadProductos];
            precios = new double[cantidadProductos];
            nuevosPrecios = new double[cantidadProductos];

            for (int i = 0; i < cantidadProductos; i++)
			{
				//Introducir nombre de productos
				Console.WriteLine("Introduzca el nombre del producto");
				productos[i] = Console.ReadLine();

				//Introducir precio de producto previamente introducido en su vector correspondiente
				Console.WriteLine("Introduzca el precio de {0}", productos[i]);
				while (!Double.TryParse(Console.ReadLine(), out precios[i]) || precios[i] <= 0)
				{
					Console.WriteLine("Error! el precio del producto debe ser un número mayor que 0");
				}
				nuevosPrecios[i] = precios[i];

				//Contador para regalo de productos
				if (i % 3 == 0)
				{
					productosRegalados++;
				}
				//Comprobación de precio menor
				if (i == 0)
				{
					precioMenor = precios[i];
				}
				else
				{
					if (precios[i] < precioMenor)
					{
						precioMenor = precios[i];
						posicionPrecioMenor = i;
					}
				}
			}
			//Comprobación de 
			if (productosRegalados > 0)
			{
				nuevosPrecios[posicionPrecioMenor] = 0;

                for (int i = 0; i < cantidadProductos; i++)
                {
                    nuevosPrecios
			    }
            }

        }
	}
}