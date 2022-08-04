﻿using System;
using System.Collections.Generic;

namespace ReferenceManager.App.Models
{
    public partial class RefArrendadorLocal
    {
        public int Id { get; set; }
        public string QueArrienda { get; set; }
        public string TiempoArriendo { get; set; }
        public string TipoNegocio { get; set; }
        public string CantidadEmpleados { get; set; }
        public string DireccionLocal { get; set; }
        public string QuienVive { get; set; }
        public string EstadoCivil { get; set; }
        public string NombreConyuge { get; set; }
        public decimal CanonArriendo { get; set; }
        public string IncluyeServicios { get; set; }
        public string PuntualResponsable { get; set; }
        public string Concepto { get; set; }
    }
}
