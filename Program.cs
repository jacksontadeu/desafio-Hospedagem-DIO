using DesafioHospedagem.Models;

namespace DesafioHospedagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> hospedes = new List<Pessoa>();
            Pessoa p1 = new Pessoa("Jackson", "Moraes");
            Pessoa p2 = new Pessoa("Luciana", "Moraes");
            hospedes.Add(p1);
            hospedes.Add(p2);

            Suite suite = new Suite("Master", 3, 30.00M);

            Reserva reserva = new Reserva(10);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            Console.WriteLine($"Hóspedes....: {reserva.ObterQuantidadeDeHospedes()}");
            Console.WriteLine($"Valor Diária: {reserva.CalcularValorDiaria().ToString("C")}");


        }
    }
}