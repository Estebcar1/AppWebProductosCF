using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppWebProductosCF.Models;

namespace AppWebProductosCF.Models
{
    public class AppWebProductosCFContext : DbContext
    {
        public AppWebProductosCFContext (DbContextOptions<AppWebProductosCFContext> options)
            : base(options)
        {
        }

        public DbSet<AppWebProductosCF.Models.Categoria> Categoria { get; set; }

        public DbSet<AppWebProductosCF.Models.Producto> Producto { get; set; }
    }
}
