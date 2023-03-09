using Veiculos.com.willy.veiculos.entities;
using Veiculos.com.willy.veiculos.entities.carTypes;
using Veiculos.com.willy.veiculos.entities.motoTypes;

int op; String placa = null; String chassi = null; String renavam = null; String cor = null;
Console.WriteLine("Selecione o tipo de veiculo que deseja criar\n(1) = Carro\n(2) = Moto");
op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
        Console.WriteLine("Selecione o modelo do carro\n(1): Sedan\n(2): Pickap");
        op = int.Parse(Console.ReadLine());
        if (op == 1)
        {
            Console.WriteLine("Sedan");
            Infos(ref placa, ref chassi, ref renavam, ref cor);
            Sedan sedan = new Sedan(placa, chassi, renavam, cor);
            Console.WriteLine(sedan);
            break;
        }
        else if (op == 2)
        {
            Console.WriteLine("Pickap");
            Infos(ref placa, ref chassi, ref renavam, ref cor);
            Pickap pickap = new Pickap(placa, chassi, renavam, cor);
            Console.WriteLine(pickap);
            break;
        }
        break;
    case 2:
        Console.WriteLine("Selecione o modelo da Moto\n(1): Kawasaki\n(2): Sanxez");
        op = int.Parse(Console.ReadLine());
        if (op == 1)
        {
            Console.WriteLine("Kawasaki");
            Infos(ref placa, ref chassi, ref renavam, ref cor);
            Kawasaki kawasaki = new Kawasaki(placa, chassi, renavam, cor);
            Console.WriteLine(kawasaki);
            break;
        }
        else if (op == 2)
        {
            Console.WriteLine("Sanxez");
            Infos(ref placa, ref chassi, ref renavam, ref cor);
            Sanxez Sanxez = new Sanxez(placa, chassi, renavam, cor);
            Console.WriteLine(Sanxez);
            break;
        }
        break;
    default: Console.WriteLine("Não existe"); break;
}

static void Infos(ref string placa, ref string chassi, ref string renavam, ref string cor)
{
    Console.WriteLine("Digite sua placa: ");
    placa = Console.ReadLine();
    Console.WriteLine("Digite o Chassi: ");
    chassi = Console.ReadLine();
    Console.WriteLine("Digite o Renavam");
    renavam = Console.ReadLine();
    Console.WriteLine("Digite a cor");
    cor = Console.ReadLine();
}



