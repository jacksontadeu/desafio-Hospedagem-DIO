using System;
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

        public Reserva() { }
        public Reserva(int diasReservados)
        {  
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("Quantidade de hóspedes maior que a capacidade da suite!!!");
            }else
            {
                Hospedes = hospedes;
            }
            
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeDeHospedes()
        {
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria()
        {
            if (this.DiasReservados >= 10)
            {
                decimal valor = Suite.ValorDiaria * this.DiasReservados * 0.9M;
                return valor ;
            }
            else
            {
                decimal valor = Suite.ValorDiaria * this.DiasReservados;
                return valor;
            }
            
        }
    }
}
