﻿using RpgGame.habilidades;
using RpgGame.Interface;
using RpgGame.models;
using System.Reflection;
using System.Linq;
using System;

namespace RpgGame.view
{
    public static class Operacoes
    {
        public static void CriarPersonagem(ref PersonagemJogador personagem)
        {
            Console.Write("Digite o nome do personagem: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Selecione uma classe para o personagem:");
            Console.WriteLine("1 = Guerreiro \n2 = Mago\n3 = Ninja");
            char op = Console.ReadKey().KeyChar;
            switch (op)
            {
                case '1':
                    personagem = new Guerreiro(nome);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O guerreiro {nome} despertou no mundo!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case '2':
                    personagem = new Mago(nome);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O Mago {nome} despertou no mundo!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case '3':
                    personagem = new Ninja(nome);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O Ninja {nome} despertou no mundo!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
        public static void SubstituirHabilidade(List<Habilidade> list, Habilidade hab)
        {
            Console.WriteLine($"\nNumero maximo de habilidades possuidos\nDeseja substituir alguma das habilidades pela {hab.Nome} ? (S/N)");
            ListarHabilidades(list); //Remover função posteriormente
            char op = Console.ReadKey().KeyChar;
            if (op == 's' || op == 'S')
            {
                Console.WriteLine("\nSelecione a habilidade para substituir: ");
                ListarHabilidades(list); //Remover função posteriormente, Mesma da de cima
                int ope = int.Parse(Console.ReadLine());
                Console.Clear();
                InserirHabilidade(ope, list, hab); //Remover função posteriormente, Função de atribuir a habilidade
            }
            else if (op == 'n' || op == 'N')
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalido");
            }
        }
        public static void InserirHabilidade(int op, List<Habilidade> list, Habilidade hab)
        {
            if (op == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Substituido {list[0].Nome} por {hab.Nome}");
                Console.ForegroundColor = ConsoleColor.White;
                list[0] = hab;
            }
            else if (op == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Substituido {list[1].Nome} por {hab.Nome}");
                Console.ForegroundColor = ConsoleColor.White;
                list[1] = hab;
            }
            else if (op == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Substituido {list[2].Nome} por {hab.Nome}");
                Console.ForegroundColor = ConsoleColor.White;
                list[2] = hab;
            }
            else if (op == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Substituido {list[3].Nome} por {hab}");
                Console.ForegroundColor = ConsoleColor.White;
                list[3] = hab;
            }
            else
                Console.WriteLine("Opção invalida");

        }
        public static void ListarHabilidades(List<Habilidade> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1} -- {list[i].Nome}");
            }
        }
        public static void GerarMonstro()
        {

        }
        public static string GeradorDeNome(int tier)
        {
            string name;
            Random ran = new Random();
            List<string> Prefix = new List<string> { "Necro ", "Sombrio ", "Tenebro ", "Cadavero ", "Profano ", "Sinistro ", "Maldito ", "Amaldiçoado " };
            List<string> tipo = new List<string>() { "desalmado ", "desossado ", "andarilho ", "renegado ", "arrepiante ", "sanguinário ", "medonho ", "macabro " };
            List<string> Sufix = new List<string>() { "das trevas", "do abismo", "destruído", "do Além", "da morte eterna", "da escuridão", "das sombras", "das almas perdidas" };
            string Pref = Prefix[ran.Next(Prefix.Count)];
            string Tip = tipo[ran.Next(tipo.Count)];
            string Suf = Sufix[ran.Next(Sufix.Count)];
            if (tier == 4)
            {
                name = "ALFA " + Pref + Tip + Suf;
            }
            else
            {
                name = Pref + Tip + Suf;
            }
            return name;
        }
        public static int GerarTier()
        {
            int num;
            Random r = new Random();
            num = r.Next(0, 100);
            if (num <= 35)
            {
                return 1;
            }
            else if (num > 35 && num <= 85)
            {
                return 2;
            }
            else if (num > 85 && num <= 95)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        public static int GerarNivel(int tier, IStatus p)
        {
            Random r = new Random();
            int level;
            int minLevel = p.atributo.Nivel - (tier + 1);
            int maxLevel = p.atributo.Nivel + (2 * tier);

            level = r.Next(minLevel, maxLevel);
            if (level <= 1)
            {
                return 1;
            }
            else
            {
                return level;
            }
        }
        public static int GerarHp(int tier, int nivel) //Com 2 jogadores, adicionar um If com 1.2 de multiplicador na base final
        {
            Random r = new Random();
            double maxHp;
            int Base;
            int VidaPNivel = r.Next(1, 3);
            if (tier == 1)
            {
                Base = r.Next(20, 30);
                maxHp = ((Base + (nivel * VidaPNivel) * (r.NextDouble() * 0.2 + 0.7)) * 1);//De 0.7 a 0.9 
            }
            else if (tier == 2)
            {
                Base = r.Next(25, 35);
                maxHp = ((Base + (nivel * VidaPNivel) * (r.NextDouble() * 0.4 + 0.8)) * 1.1); //de 0.8 a 1.2
            }
            else if (tier == 3)
            {
                Base = r.Next(30, 40);
                maxHp = ((Base + (nivel * VidaPNivel) * (r.NextDouble() * 0.4 + 1.2)) * 1.15); //de 1.2 a 1.6
            }
            else
            {
                Base = r.Next(60, 80);
                VidaPNivel = r.Next(2, 3);
                if (nivel > 30)
                {

                    maxHp = ((Base + (nivel * VidaPNivel) * (r.NextDouble() * 0.2 + 2.0)) * 1.2); //de 2.0 a 2.2
                }
                else
                {
                    maxHp = ((Base + (nivel * VidaPNivel) * (r.NextDouble() * 0.2 + 2.0)) * 1); //de 2.0 a 2.2
                }
            }
            int x = (int)maxHp;
            return x;
        }
        public static int GerarAtk(int tier, int nivel)
        {
            Random r = new Random();
            double Atk;
            int Base;
            double AtkPNivel = r.NextDouble() + 1;
            if (tier == 1)
            {
                Base = r.Next(3, 6);
                Atk = ((Base + ((nivel * AtkPNivel) * ((r.NextDouble() * 0.2) + 0.9)) * (0.7)) * 0.75);//De 0.7 
            }
            else if (tier == 2)
            {
                Base = r.Next(4, 8);
                Atk = ((Base + ((nivel * AtkPNivel) * ((r.NextDouble() * 0.2) + 0.9)) * (0.75)) * 0.8); //de 0,75
            }
            else if (tier == 3)
            {
                Base = r.Next(6, 10);
                Atk = ((Base + ((nivel * AtkPNivel) * ((r.NextDouble() * 0.2) + 0.9)) * (0.8)) * 0.85);//De 10.8
            }
            else
            {
                Base = r.Next(11, 18);
                AtkPNivel = r.Next(2, 3);
                if (nivel > 30)
                {

                    Atk = ((Base + ((nivel * AtkPNivel) * ((r.NextDouble() * 0.2) + 0.9)) * ((r.NextDouble() * 0.3 + 0.9))) * 0.9);//De 0,9 a 1.2 ;
                }
                else
                {
                    Atk = ((Base + ((nivel * AtkPNivel) * ((r.NextDouble() * 0.2) + 0.9)) * ((r.NextDouble() * 0.3 + 0.9))) * 0.7);//De 0,9 a 1.2 ;
                }
            }
            int x = (int)Atk;
            return x;
        }
        public static int RealizarFunc(int x, int y, Func<int, int, int> Func) //Uso de delegate
        {
            return Func(x, y);
        }
        public static bool FugirCombateBETA(PersonagemJogador p, PersonagemMonstro m)
        {
            Random r = new Random();
            int val = r.Next(1, 100);
            if (val < 60)
            {
                return true; //Sai do combate
            }
            else
            {
                return false; //Não sai do combate
            }
        } //EXCLIR, FOI CRIADO P/ GABRIEL TESTAR
        public static bool FugirCombate(PersonagemJogador p, PersonagemMonstro m)
        {
            Random r = new Random();
            double chanceFuga = p.atributo.Nivel / (2 * m.atributo.Nivel + m.tier); //  Conta meio estranha, sempre beira 50%
            double fuga = r.NextDouble();
            if (chanceFuga > fuga)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Habilidade> GerarHab(int Tier, int nivel)
        {
            List<Habilidade> buscaHabilidade = new List<Habilidade>();
            List<Habilidade> allSkill = new List<Habilidade>();
            CarregarHabilidades(ref allSkill);
            if (Tier == 4)
            {
                var habDisp = allSkill.Where(h => h.Tier == 4);
                SelecionarHabilidades(habDisp, ref buscaHabilidade, Tier,nivel);
                List<Habilidade> HabReturn = new List<Habilidade>();
                HabReturn.Add(new AtaqueBasico());
                HabReturn.AddRange(buscaHabilidade);
                return HabReturn;
            }
            else if (Tier == 3)
            {
                var habDisp = allSkill.Where(h => h.Tier == 4 || h.Tier == 3);
                SelecionarHabilidades(habDisp, ref buscaHabilidade, Tier, nivel);
                List<Habilidade> HabReturn = new List<Habilidade>();
                HabReturn.Add(new AtaqueBasico());
                HabReturn.AddRange(buscaHabilidade);
                return HabReturn;
            }
            else if (Tier == 2)
            {
                var habDisp = allSkill.Where(h => h.Tier == 3 || h.Tier == 2);
                SelecionarHabilidades(habDisp, ref buscaHabilidade, Tier, nivel);
                List<Habilidade> HabReturn = new List<Habilidade>();
                HabReturn.Add(new AtaqueBasico());
                HabReturn.AddRange(buscaHabilidade);
                return HabReturn;
            }
            else
            {
                var habDisp = allSkill.Where(h => h.Tier == 2 || h.Tier == 1);
                SelecionarHabilidades(habDisp, ref buscaHabilidade, Tier, nivel);
                List<Habilidade> HabReturn = new List<Habilidade>();
                HabReturn.Add(new AtaqueBasico());
                HabReturn.AddRange(buscaHabilidade);
                return HabReturn;
            }
        }
        public static List<Habilidade> CarregarHabilidades(ref List<Habilidade> allSkill)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var habilidades = assembly.GetTypes().Where(Type => Type.IsSubclassOf(typeof(Habilidade)) && Type != typeof(AtaqueBasico));
            foreach (Type subclass in habilidades)
            {
                Habilidade habilidade = (Habilidade)Activator.CreateInstance(subclass);
                allSkill.Add(habilidade);
            }
            return allSkill;
        }
        public static List<Habilidade> SelecionarHabilidades(IEnumerable<Habilidade> Skills, ref List<Habilidade> h, int Tier, int nivel)
        {
            double probability = 1.0 - (nivel / 100.0); // Cálculo da probabilidade com base no nível
            Random rnd = new Random();
            List<int> jaContem = new List<int>();
            if (!(Tier == 4))
            {
                var listDTier = Skills.Where(t => t.Tier == Tier).ToList();
                var listTTier = Skills.Where(t => t.Tier == Tier + 1).ToList();
                while (jaContem.Count < 3)
                {
                    if (rnd.NextDouble() < probability) //low
                    {
                        int index = rnd.Next(listDTier.Count);
                        if (!jaContem.Contains(index))
                        {
                            h.Add(listDTier[index]);
                            jaContem.Add(index);
                        }
                    }
                    else
                    {
                        int index = rnd.Next(listDTier.Count);
                        if (!jaContem.Contains(index))
                        {
                            h.Add(listTTier[index]);
                            jaContem.Add(index);
                        }
                    }
                }
                return h;
            }
            else
            {
                var habList = Skills.ToList();
                while (jaContem.Count < 3 && habList.Count > 0)
                {
                    int index = rnd.Next(habList.Count);
                    if (!jaContem.Contains(index))
                    {
                        h.Add(habList[index]);
                        jaContem.Add(index);
                    }
                }
                return h;
            }
        } //Implementar a probabiliadade de escolha entre niveis maiores
    }
}
