﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
     public class CategoriaHospedaje
    {
        public int CategoriaHospedajeId { get; set; }

        public int HospedajeId { get; set; }
        public Hospedaje Hospedaje { get; set; }


    }
}
