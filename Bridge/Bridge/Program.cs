using Bridge;
using Bridge.Abstracao;
using Bridge.Implementacao;
using System.Reflection.PortableExecutable;

Client client;
Random random;

while (true)
{
    client = new Client();
    random = new Random();

    if (random.Next(2) == 1)
        client.Material = new CanetaEsferografica();
    else
        client.Material = new PincelMarcador();


    if (random.Next(1, 3) == 1)
        client.Material.CorImplementacao = new Azul();

    else if (random.Next(1, 3) == 2)
        client.Material.CorImplementacao = new Preto();
    else
        client.Material.CorImplementacao = new Vermelho();

    client.ConsultarCanetasPinceisNoEstoque();

    Console.WriteLine("Pressione <enter> para continuar ou qualquer tecla para finalizar");
    ConsoleKeyInfo key = Console.ReadKey();

    if (key.KeyChar != 13)
        break;
}