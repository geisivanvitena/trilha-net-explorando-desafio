namespace trilha_net_explorando_desafio.Models
{
    public class Reserva
    {
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        private List<Pessoa> _hospedes = new List<Pessoa>();
        private Suite _suite;
        private int _diasReservados = 0;

        public List<Pessoa> Hospedes
        {
            get => _hospedes;

            set => _hospedes = value;
        }

        public Suite Suite
        {
            get => _suite;

            set => _suite = value;
        }

        public int DiasReservados
        {
            get => _diasReservados;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Dias reservados deve ser maior que zero.");
                }
                _diasReservados = value;
            }
        }

        // IMPLEMENTADO
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes == null || hospedes.Count == 0)
            {
                throw new ArgumentException("Você precisa cadastrar um hóspede.");
            }

            Hospedes = hospedes;
        }

        // IMPLEMENTADO
        public void CadastrarSuite(Suite suite)
        {
            if (suite == null)
            {
                throw new ArgumentException("Você precisa cadastrar uma suíte.");
            }

            if (Hospedes.Count > suite.Capacidade)
            {
                throw new ArgumentException("A quantidade de hóspedes excede a capacidade da suíte.");
            }
            Suite = suite;
        }

        // IMPLEMENTADO
        public int ObterQuantidadeDeHospedes()
        {
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        // IMPLEMENTADO
        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10M;
            }

            return valor;
        }

    }
}