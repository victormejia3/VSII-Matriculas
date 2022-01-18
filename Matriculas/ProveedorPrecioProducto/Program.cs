using System;
using System.Collections.Generic;

namespace ProveedorPrecioProducto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear dos proveedores
            Proveedor Pelikan = new Proveedor() { Nombre = "Pelikan S.A." };
            Proveedor BIC = new Proveedor() { Nombre = "BIC Esferográficos" };

            // Productos
            Producto Borrador = new Producto() { Nombre = "Borrador tinta", Unidad = "Unidad" };
            Producto EsferoAzul = new Producto() { Nombre = "Esfero Azul", Unidad = "caja 10" };
            Producto EsferoRojo = new Producto() { Nombre = "Esfero Rojo", Unidad = "caja 10" };
            Producto PapelA4= new Producto() { Nombre = "Papel A4", Unidad = "Resma" };
            Producto Tonner = new Producto() { Nombre = "Tonner Nego", Unidad = "Unidad" };

            // Lista de precios por proveedor BIC
            Oferta precioEsferoAzulBIC = new Oferta()
            {
                producto = EsferoAzul,
                proveedor = BIC,
                precio= (decimal)1.50
            };
            Oferta precioEsferoRojoBIC = new Oferta()
            {
                producto = EsferoRojo,
                proveedor = BIC,
                precio= (decimal)1.60
            };

            BIC.ListaOfertas = new List<Oferta>() 
            {
                precioEsferoAzulBIC, 
                precioEsferoRojoBIC 
            };

            // Lista de precios de Pelikan
            Oferta precioTonner = new Oferta
            {
                proveedor=Pelikan,
                producto=Tonner,
                precio= (decimal) 40.15
            };
            Oferta precioPapelA4 = new Oferta
            {
                proveedor = Pelikan,
                producto = PapelA4,
                precio = (decimal)3.25
            };
            Oferta precioBorrador = new Oferta
            {
                proveedor = Pelikan,
                producto = Borrador,
                precio = (decimal)0.25
            };

            Pelikan.ListaOfertas = new List<Oferta>()
            { 
                precioBorrador,
                precioPapelA4,
                precioTonner
            };
        }
    }
}
