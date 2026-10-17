
string producto = "Teclado";
double precio = 85000;
int cantidad = 2;
double subtotal = precio * cantidad;
double descuento = subtotal * 0.10;
double total = subtotal - descuento;

Console.WriteLine("FACTURA DE COMPRA");
Console.WriteLine("-----------------");
Console.WriteLine($"Producto: {producto}");
Console.WriteLine($"Precio unitario: ${precio:N0}");
Console.WriteLine($"Cantidad: {cantidad}");
Console.WriteLine($"Subtotal: ${subtotal:N0}");
Console.WriteLine($"Descuento (10%): ${descuento:N0}");
Console.WriteLine($"Total a pagar: ${total:N0}");
