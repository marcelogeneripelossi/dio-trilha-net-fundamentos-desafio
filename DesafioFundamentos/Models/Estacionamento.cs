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
            // Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            string veiculo = string.Empty; ;

            do
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                veiculo = Console.ReadLine();
            } while (String.IsNullOrEmpty(veiculo.Trim()));

            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {

            if (!veiculos.Any())
            {
                Console.WriteLine("Não há veículos estacionados.");
                return;
            }

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = "";

            do
            {

                Console.WriteLine("Digite a placa do veículo para remover:");
                placa = Console.ReadLine();

            } while (String.IsNullOrEmpty(placa.Trim()));

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0;

                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                do
                {

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    Int32.TryParse(Console.ReadLine(), out horas);

                } while (horas <= 0);

                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                valorTotal = precoInicial + precoPorHora * horas;

                // Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (var veiculo in veiculos)
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
