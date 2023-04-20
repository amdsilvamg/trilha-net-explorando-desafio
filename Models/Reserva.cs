namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (hospedes.Count<=Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception ("O número de hóspedes excede a capacidade do quarto");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados<10)
                return DiasReservados*Suite.ValorDiaria;
            else
            {
                const decimal desconto = 0.1M;
                Suite.ValorDiaria-=Suite.ValorDiaria*desconto;
                return DiasReservados*Suite.ValorDiaria;
            }    
        }
    }
}