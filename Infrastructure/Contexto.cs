using System;
using Microsoft.EntityFrameworkCore;
using Ventas.Core.Entidades;

namespace Ventas.Infrastructure;

public class Contexto : DbContext
{
    public DbSet<Cateogria> Categorias { get; set; }
    public DbSet<Articulo> Articulos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
}