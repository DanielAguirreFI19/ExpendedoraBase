using System;
using System.Threading;


namespace ExpendedoraBase
{
    public class Expendedora
    {
        //Atributos
        string marca;
        byte temperatura;
        string codigo;
        float precio;

        public Expendedora()
        {
            saludar();
            marca = "AMS";
            Console.WriteLine("Marca: " + marca);
            controlarTiempoDispay();
            temperatura = 14;
            Console.Write("La temperatura es: " + temperatura + "°C");
            controlarTiempoDispay();
            codigo = mostrarCodigoDeProductos();
            mostrarPrecio(codigo);
        }
        void controlarTiempoDispay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        void saludar()
        {
            Console.WriteLine("Bienvenido");
        }
        string mostrarCodigoDeProductos()
        {
            Console.WriteLine("A1: Kinder Delice \tB2: Takis \tC3: Donitas");
            Console.WriteLine("Ingresa el codigo del producto a elegir");
            string codigo = Console.ReadLine();//Variable Local
            return codigo;
        }
        void mostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "A1":
                    {
                        Console.WriteLine("El precio es: {0}", precio);

                    }break;

                case "B2":
                    {
                        Console.WriteLine("El precio es: {0}", precio);

                    }
                    break;

                case "C3":
                    {
                        Console.WriteLine("El precio es: {0}", precio);

                    }
                    break;
                default:
                    {
                        Console.WriteLine("Producto no reconocido");
                    }break;
            }
        }
    }
}
