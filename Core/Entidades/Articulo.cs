using System;

namespace Ventas.Core.Entidades;

public class Articulo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int CateogriaId { get; set;}
}