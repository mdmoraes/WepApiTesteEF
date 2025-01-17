﻿using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using WepApiTesteEF.Models;

namespace WepApiTesteEF.Dados
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext(DbContextOptions<WebAPIContext> options)
        : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; } = default!;
        public DbSet<Cidade> Cidade { get; set; } = default!;
        public DbSet<Estado> Estado { get; set; } = default!;
    }
}
