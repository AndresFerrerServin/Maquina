using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina
{
    public class Productos
    {
        

        public  static Producto.Producto Seleccion()
        {
            int A = 270, B = 340, C = 390;
            Producto.Producto producto = new Producto.Producto();

            Console.WriteLine("Ingresa tu nombre: ");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("Elije un producto");
            Console.WriteLine("1; A = $270");
            Console.WriteLine("2; B = $340");
            Console.WriteLine("3; C = $390");
            producto.N = int.Parse(Console.ReadLine());

            switch (producto.N)
            {
                case 1:
                    
                    Console.WriteLine("Producto: A = 270");
                    Console.WriteLine("Selecciona una moneda");
                    Console.WriteLine("1= $10");
                    Console.WriteLine("2= $50");
                    Console.WriteLine("3= $100");
                    producto.Moneda = int.Parse(Console.ReadLine());
                    while (producto.Moneda >= A)
                    {
                        producto.Faltante = producto.Moneda - A;
                        Console.WriteLine("Falta dinero, Ingresa el faltante = " + producto.Faltante);
                        producto.Faltante = int.Parse(Console.ReadLine());
                        producto.Moneda = producto.Moneda + producto.Faltante;

                    }
                    break;

                case 2:

                    Console.WriteLine("Producto: B = 340");
                    Console.WriteLine("Selecciona una moneda");
                    Console.WriteLine("1= $10");
                    Console.WriteLine("2= $50");
                    Console.WriteLine("3= $100");
                    producto.Moneda = int.Parse(Console.ReadLine());
                    while (producto.Moneda >= B)
                    {
                        producto.Faltante = producto.Moneda - B;
                        Console.WriteLine("Falta dinero, Ingresa el faltante = " + producto.Faltante);
                        producto.Faltante = int.Parse(Console.ReadLine());
                        producto.Moneda = producto.Moneda + producto.Faltante;

                    }
                    break;

                case 3:

                    Console.WriteLine("Producto: C = 390");
                    Console.WriteLine("Selecciona una moneda");
                    Console.WriteLine("1= $10");
                    Console.WriteLine("2= $50");
                    Console.WriteLine("3= $100");
                    producto.Moneda = int.Parse(Console.ReadLine());
                    while (producto.Moneda >= C)
                    {
                        producto.Faltante = producto.Moneda - C;
                        Console.WriteLine("Falta dinero, Ingresa el faltante = " + producto.Faltante);
                        producto.Faltante = int.Parse(Console.ReadLine());
                        producto.Moneda = producto.Moneda + producto.Faltante;

                    }
                    break;


            }
            return producto;  
        }
        public static Producto.Producto Cambio()
        {
            Producto.Producto cambio = new Producto.Producto();

            return cambio;
        }
    }
}
