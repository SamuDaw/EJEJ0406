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
            int productosRegaladosRestantes = 0;

			string[] productos;
			double[] precios;
			double[] nuevosPrecios; 
			double precioMenor = 0;
            double precioMayor = 0;
			double precioTotalFinal = 0;

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
				if (((i+1) >= 3) && ((i+1) % 3 == 0))
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
					if (precios[i] > precioMayor)
					{
						precioMayor = precios[i];
					}
				}
			}

			productosRegaladosRestantes = productosRegalados;

			//Comprobación de 
			if (productosRegalados > 0)
			{
                nuevosPrecios[posicionPrecioMenor] = 0;
				productosRegaladosRestantes--;

				//Bucle de recorrido en relación a número de productos regalados
				for (int i = productosRegaladosRestantes; i > 0 ; i--)
				{
					//Reseteo de variable precio menor
					precioMenor = precioMayor;

					//Bucle de recorrido de array de precios finales
                    for (int j = 0; j < cantidadProductos; j++)
                    {
						if ((nuevosPrecios[j] < precioMenor) && (nuevosPrecios[j] != 0))
						{
							precioMenor = nuevosPrecios[j];
							posicionPrecioMenor = j;
						}
                    }
					//Asignación de valor 0 a producto de menor precio
					nuevosPrecios[posicionPrecioMenor] = 0;
                }
                //Bucle de recorrido de array para salida
                for (int i = 0; i < cantidadProductos; i++)
                {
                    Console.Write("\nProducto: {0}  Precio inicial: {1:f2}  Precio final:  {2:f2} ", productos[i], precios[i], nuevosPrecios[i]);
                    precioTotalFinal += nuevosPrecios[i];
                }
            }
			//Salida en caso de no aplicarse descuento
			else
			{
				Console.WriteLine("No se ha llegado al mínimo de productos para aplicar la oferta del producto regalado");
                for (int i = 0; i < cantidadProductos; i++)
                {
                    precioTotalFinal += nuevosPrecios[i];
                }
            }

			//Salida de precio final
			Console.WriteLine("\nPrecio total a pagar: {0}", precioTotalFinal);
        }
	}
}