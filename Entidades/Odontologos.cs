﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Odontologos
    {
        [Key]
        public int OdontologoId { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Especialidad { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Odontologos()
        {
            OdontologoId = 0;
            Nombres = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Especialidad = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty;
            FechaIngreso = DateTime.Now;
        }
     


    }
}
