﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities.IReposiroty
{
    public interface IRepoServicioHospedaje
    {
        IEnumerable<ServicioHospedaje> getServicioporHospedaje(Hospedaje hospedaje);

    }
}
