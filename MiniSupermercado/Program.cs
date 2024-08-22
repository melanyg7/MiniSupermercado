using System;

class MiniSupermarket
{
     static void Main(string[] args)
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

        double precio=0;
        string Producto;

        if (categoria == "1")
        {
            Console.WriteLine("Tenemos los siguientes Productos, escriba el numero deseado");
            Console.WriteLine("1. Coca cola 30 Lps");
            Console.WriteLine("2. Sevens 28 Lps");
            Console.WriteLine("3. Savile 23 Lps");
            Producto = Console.ReadLine();

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
                precio = 0;
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
                precio = 0;
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
                precio = 0;
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
                precio = 0;
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
                precio = 0;
            }
        }
        else
        {
            Console.WriteLine("El numero de producto seleccionado no existe");
        }


        Console.WriteLine("Elija el tamaño de su producto:");
        Console.WriteLine("A. Grande ");
        Console.WriteLine("B. Mediano ");
        Console.WriteLine("C. Pequeño");
        int tamaño = Convert.ToInt32(Console.ReadLine());
        if (tamaño == 1)
        {
            precio = precio;
        }
        else if (tamaño == 2)
        {
            precio = precio * 1.2;
        }
        else if (tamaño == 3)
        {
            precio = precio * 1.2 * 1.3;
        }
        Console.WriteLine("El precio del producto es: " + precio);
        Console.Write("Ingrese la cantidad deseada: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        double subtotal = (precio * cantidad);
        double
        impuesto = 0;
        if (categoria == "1")
        {
            impuesto = 0;
        }
        else
        {
            impuesto = subtotal * 0.15;
        }
        double descuento = 0;
        if (Edad >= 60)
        {
            descuento = subtotal * 0.3;
        }
        else
        {
            descuento = 0;
        }

    double total =subtotal+impuesto-descuento;
        Console.WriteLine("El valor a pagar es de:" + total,"Usted esta pagando un impuesto de:" + impuesto,"Y un descuento de:" + descuento);
        Console.WriteLine($"El valor a pagar es de;); {total} Usted esta pagando un impuesto de: {impuesto} Y un descuento de: {descuento} ");

        
    }
}
