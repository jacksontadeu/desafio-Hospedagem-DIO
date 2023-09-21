﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHospedagem.Models
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes { get ; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

    }
}