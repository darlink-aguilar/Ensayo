// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

var zapato1 = new Zapatos();
var zapato2 = new Tacones();

zapato1.id = 1;
zapato1.modelo = "2025";
zapato1.talla = 39.0m;
zapato1.existencia = true;
zapato1.fecha = DateTime.Now;

Console.WriteLine(zapato1.id);



public class Zapatos
{
    public int id;
    public string? modelo;
    public decimal talla;
    public bool existencia;
    public DateTime fecha;
}

public class Tacones : Zapatos
{
    public string? color;
    public decimal altura;
}

public class Clientes
{
    public int id;
    public string? nombre;
    public decimal tallaC;
    public bool compra;
    public DateTime fecha;
    public List<Zapatos>? zapatos;
}


