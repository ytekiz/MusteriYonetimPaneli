﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-FFUM9JB;database=MernisAppDb;integrated security=true;");
        }
        public DbSet<Mernis> Merniss{ get; set; }
        public DbSet<PortalUser> PortalUsers{ get; set; }
    }
    }

