﻿using Microsoft.EntityFrameworkCore;
using MvcNetCorePaginacionRegistros.Models;

namespace MvcNetCorePaginacionRegistros.Data
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
            :base(options) { }

        public DbSet<VistaDepartamento> VistaDepartamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
