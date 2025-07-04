namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // *IMPLEMENTADO*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

             if (!string.IsNullOrWhiteSpace(placa))
             {
                if (veiculos.Any(v => v.Equals(placa, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"O veículo com a placa {placa} já está estacionado.");
               }
                else
                {
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com a placa {placa} estacionado com sucesso!");
         }
        }
        else
        {
        Console.WriteLine("Placa inválida. Por favor, digite uma placa.");
        }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // *IMPLEMENTADO*
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
      
                // *IMPLEMENTADO*
                 int horas;
                decimal valorTotal;

                while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número de horas válido.");
                }

                valorTotal = precoInicial + precoPorHora * horas;

                // *IMPLEMENTADO*
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // *IMPLEMENTADO*
                 foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
