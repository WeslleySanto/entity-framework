﻿using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        //override On
    }
}
