using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Prueba.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        DbSet<Cliente> Clientes { get; set; }
    }
}
