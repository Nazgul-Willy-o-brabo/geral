using RpgGame.models;
using RpgGame.view;

//Item i = new PocaoCura();


//int cont = 0;
//var t1 = Assembly.GetExecutingAssembly().GetTypes()
//    .Where(T => T.IsSubclassOf(typeof(Habilidade)))
//    .Select(t => Activator.CreateInstance(t) as Habilidade)
//    .Where(h => h.ClassType == 1).OrderBy(h => h.Custo).OrderBy(h => h.Tier);

//var t2 = Assembly.GetExecutingAssembly().GetTypes()
//    .Where(T => T.IsSubclassOf(typeof(Habilidade)))
//    .Select(t => Activator.CreateInstance(t) as Habilidade)
//    .Where(h => h.ClassType == 2).OrderBy(h => h.Custo).OrderBy(h => h.Tier);

//var t3 = Assembly.GetExecutingAssembly().GetTypes()
//    .Where(T => T.IsSubclassOf(typeof(Habilidade)))
//    .Select(t => Activator.CreateInstance(t) as Habilidade)
//    .Where(h => h.ClassType == 3).OrderBy(h => h.Custo).OrderBy(h => h.Tier);



//Console.WriteLine("Guerreiro\n");
//foreach (var type in t1)
//{
//    Console.WriteLine($"{type.Tier} -- {type.Nome} -- Custo: {type.Custo}");
//    cont++;
//}
//Console.WriteLine("\n" + cont);
//Console.WriteLine("---------");

//cont = 0;
//Console.WriteLine("Mago\n");
//foreach (var type in t2)
//{
//    Console.WriteLine($"{type.Tier} -- {type.Nome} -- Custo: {type.Custo}");
//    cont++;
//}
//Console.WriteLine("\n" + cont);
//Console.WriteLine("---------");

//cont = 0;
//Console.WriteLine("Assassino\n");
//foreach (var type in t3)
//{
//    Console.WriteLine($"{type.Tier} -- {type.Nome} -- Custo: {type.Custo}");
//    cont++;
//}
//Console.WriteLine("\n"+cont);
//Console.WriteLine("---------");

PersonagemJogador player = null;
Operacoes.CriarPersonagem(ref player);

for(int i = 0; i < 10; i++)
{
    Console.WriteLine(new CriaturaDaNoite(player));
    Console.WriteLine();
}

