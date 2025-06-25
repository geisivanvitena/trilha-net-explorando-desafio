using trilha_net_explorando_desafio.Models;

try
{
    List<Pessoa> hospedes = new List<Pessoa>();

    Pessoa p1 = new Pessoa(nome: "geisivan", sobrenome: "silva");
    Pessoa p2 = new Pessoa(nome: "mariana", sobrenome: "felix");

    hospedes.Add(p1);
    hospedes.Add(p2);

    Suite suite = new Suite(tipoSuite: "Luxo", capacidade: 2, valorDiaria: 50);

    Reserva reserva = new Reserva(5);
    reserva.CadastrarHospedes(hospedes);
    reserva.CadastrarSuite(suite);

    Console.WriteLine("\n===== Gestão de hospedagem =====\n");
    Console.WriteLine("Resumo da reserva:");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Quantidade de hóspedes cadastrados: {reserva.ObterQuantidadeDeHospedes()}\n");
    Console.WriteLine("Hóspedes Cadastrados:\n");
    Console.WriteLine($"Nome: {p1.NomeCompleto}");
    Console.WriteLine($"Nome: {p2.NomeCompleto}");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Tipo de suíte: {suite.TipoSuite}");
    Console.WriteLine($"Capacidade da suíte: {suite.Capacidade}");
    Console.WriteLine($"Valor da diária (R$): {reserva.Suite.ValorDiaria:F2}");
    Console.WriteLine($"Quantidade de dias reservados: {reserva.DiasReservados}\n");
    Console.WriteLine($"Valor total à pagar (R$): {reserva.CalcularValorDiaria():F2}"); 
    Console.WriteLine("----------------------------------------");
}
catch (Exception ex)
{

    Console.WriteLine($"Atenção: Aconteceu um erro: {ex.Message}");
}


