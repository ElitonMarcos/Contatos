using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Contatos.Models
{
    public class contexto : DbContext
    {
        public DbSet<telefone> Telefone { get; set; }

    }
}