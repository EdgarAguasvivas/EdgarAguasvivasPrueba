﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdgarAguasvivasPrueba.Models
{
    public class Solicitud
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Persona  Personas { get; set; }
        public int PersonaId { get; set; }

        public  Estado Estados { get; set; }
        public int EstadoId { get; set; }
    }
}
