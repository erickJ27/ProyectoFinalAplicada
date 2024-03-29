﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace DAL
{
    public class CentroOdontologicoContexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Odontologos> Odontologos { get; set; }
        public DbSet<Especialidades> Especialidades { get; set; }
        public DbSet<Materiales> Materiales { get; set; }
        public DbSet<ConsultasM> ConsultasM { get; set; }
        public DbSet<Vacunas> Vacunas { get; set; }
        public DbSet<Alergias> Alergias { get; set; }
        public CentroOdontologicoContexto() : base("ConStr")
        {

        }

    }
}
