using System.Diagnostics;
using estacionamento;

List<Veiculo> estacionamento = new List<Veiculo>();

double valorEntrada = 5.00;
double valorPorHora = 2.00;

string menu =
  "1 - cadastrar\n"
+ "2 - remover\n"
+ "3 - listar\n"
+ "4 - Encerra\n";

void ListarVeiculos(List<Veiculo> p_estacionamento)
{
    int contador = 0;
    foreach (Veiculo carro in p_estacionamento)
    {
        contador++;
        Console.WriteLine($"Veiculo {contador} placa {carro.Placa}");
    }
}

void RemoverVeiculo(List<Veiculo> p_estacionamento)
{
    string placa;
    Console.WriteLine("digite a placa do carro que deseja retirar : ");
    placa = Console.ReadLine();

    int contador = 0;
    bool removido = false;
    foreach (Veiculo carro in p_estacionamento)
    {
        if (carro.Placa == placa)
        {
            p_estacionamento.RemoveAt(contador);
            removido = true;
            break;
        }
        contador++;
    }

    if (removido)
    {
        Console.WriteLine("quanto tempo o veiculo ficou no estacionamento?");
        int horas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($" {placa} removido com sucesso , valor a pagar = {horas * valorPorHora + valorEntrada}");
    }
    else
    {
        Console.WriteLine("Veiculo não encontrado");
    }
}




bool rodando = true;
int escolha = 0;

while (rodando)
{
    Console.WriteLine(menu);


    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("digite a placa do veiculo : ");
            estacionamento.Add(new Veiculo(Console.ReadLine()));
            break;
        case "2":
            RemoverVeiculo(estacionamento);
            break;
        case "3":
            ListarVeiculos(estacionamento);
            break;
        case "4":
            rodando = false;
            break;
        default:
            Console.WriteLine("imput invalido tente novamente");
            break;
    }

    Console.WriteLine("aperte enter para proseguir");
    Console.ReadLine();
}




