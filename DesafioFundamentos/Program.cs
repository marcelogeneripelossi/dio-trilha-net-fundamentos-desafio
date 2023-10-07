using DesafioFundamentos;
using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

do {

    Console.WriteLine("Digite o preço inicial:");
    decimal.TryParse(Console.ReadLine(), out precoInicial);

} while (precoInicial <= 0);

do
{

    Console.WriteLine("Agora, digite o preço por hora:");
    decimal.TryParse(Console.ReadLine(), out precoPorHora);

} while (precoPorHora <= 0);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;
byte opcaoMenu = 0;


// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    
    byte.TryParse(Console.ReadLine(), out opcaoMenu);
    
    switch (opcaoMenu)
    {
        case (byte)MenuEnum.Adicionar:
            estacionamento.AdicionarVeiculo();
            break;

        case (byte)MenuEnum.Remover:
            estacionamento.RemoverVeiculo();
            break;

        case (byte)MenuEnum.Listar:
            estacionamento.ListarVeiculos();
            break;

        case (byte)MenuEnum.Encerrar:
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
