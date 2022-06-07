using System;
using Microsoft.EntityFrameworkCore;
using Ventas.Core.Entidades;

namespace Ventas.Infrastructure;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Articulo> Articulos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
}