using System;

class MiniSupermarket
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de ventas de MiniSupermarket");
        Console.WriteLine("Por Favor Ingrese Su Nombre:");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Por Favor Ingrese Su Edad");
        int Edad = int.Parse(Console.ReadLine());  
        Console.WriteLine("Elija la Categoria del producto a Comprar:");
        Console.WriteLine("1. Bebidas");
        Console.WriteLine("2. Lacteos");
        Console.WriteLine("3. Carnes");
        Console.WriteLine("4. Cereales");
        Console.WriteLine("5. Frutas ");
        string categoria = Console.ReadLine();

        double precio = 0;  
        string Producto;
        string tamaño;

        if (categoria == "1")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Coca cola 30 Lps");
            Console.WriteLine("2. Sevens 28 Lps");
            Console.WriteLine("3. Savile 23 Lps");
            Producto = Console.ReadLine();

            Console.WriteLine("Elija el tamaño de su bebida:");
            Console.WriteLine("A. Grande ");
            Console.WriteLine("B. Mediano ");
            Console.WriteLine("C. Pequeño");
            tamaño = Console.ReadLine();

            if (Producto == "1")
            {
                precio = 30;
            }
            else if (Producto == "2")
            {
                precio = 28;
            }
            else if (Producto == "3")
            {
                precio = 23;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }
        }
        else if (categoria == "2")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Queso 22 Lps");
            Console.WriteLine("2. Mantequilla 30 Lps");
            Console.WriteLine("3. Queso Frijolero 35 Lps");
            Producto = Console.ReadLine();

            if (Producto == "1")
            {
                precio = 22;
            }
            else if (Producto == "2")
            {
                precio = 30;
            }
            else if (Producto == "3")
            {
                precio = 35;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }
        }
        else if (categoria == "3")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Tajo Premium 110 Lps");
            Console.WriteLine("2. Pescado 70 Lps");
            Console.WriteLine("3. Rez 110 Lps");
            Producto = Console.ReadLine();

            if (Producto == "1")
            {
                precio = 110;
            }
            else if (Producto == "2")
            {
                precio = 70;
            }
            else if (Producto == "3")
            {
                precio = 110;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }
        }
        else if (categoria == "4")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Galletas 20 Lps");
            Console.WriteLine("2. Cereal 54 Lps");
            Console.WriteLine("3. Gomitas 30 Lps");
            Producto = Console.ReadLine();

            Console.WriteLine("Elija el tamaño de su bebida:");
            Console.WriteLine("A. Grande ");
            Console.WriteLine("B. Mediano ");
            Console.WriteLine("C. Pequeño");
            tamaño = Console.ReadLine();

            if (Producto == "1")
            {
                precio = 20;
            }
            else if (Producto == "2")
            {
                precio = 54;
            }
            else if (Producto == "3")
            {
                precio = 30;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }
        }
        else if (categoria == "5")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Manzana 15 Lps");
            Console.WriteLine("2. Melon 20 Lps");
            Console.WriteLine("3. Minimo 2 Lps");
            Producto = Console.ReadLine();

            if (Producto == "1")
            {
                precio = 15;
            }
            else if (Producto == "2")
            {
                precio = 20;
            }
            else if (Producto == "3")
            {
                precio = 2;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }
        }
        else
        {
            Console.WriteLine("El numero de producto seleccionado no existe");
        }

     
        Console.WriteLine("Ingrese la cantidad que desea comprar:");
        int cantidad = int.Parse(Console.ReadLine());
        double subtotal = precio + cantidad;

      
        if (Edad >= 58)
        {
            double descuento = subtotal * 0.30; 
            subtotal -= descuento;
            Console.WriteLine("Se ha aplicado un descuento del 30% por ser de la tercera edadd. Total con descuento: subtotal Lps");
        }

        
        Console.WriteLine($"El subtotal de su compra es: {subtotal} Lps");

        Console.WriteLine("Su Compra ha sido exitosa");
    }
}
