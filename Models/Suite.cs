namespace trilha_net_explorando_desafio.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;

        public string TipoSuite
        {
            get => _tipoSuite;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Você precisa selecionar um tipo de suíte.");
                }
                _tipoSuite = value;
            }
        }

        public int Capacidade
        {
            get => _capacidade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A capacidade deve ser maior que zero.");
                }
                _capacidade = value;
            }
        }

        public decimal ValorDiaria
        {
            get => _valorDiaria;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O valor da diária deve ser maior que zero.");
                }
                _valorDiaria = value;
            }
        }
    }
}