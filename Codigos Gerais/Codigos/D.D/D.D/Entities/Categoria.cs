using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.D.Entities
{
    public abstract class Categoria
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string desc { get; set; }
        public string passiva { get; set; }
        public string lider1 { get; set; }
        public string lider2 { get; set; }
        public string lider3 { get; set; }
        public string lider4 { get; set; }

        protected Categoria(int id, string nome, string desc, string passiva, string lider1, string lider2, string lider3, string lider4)
        {
            this.id = id;
            this.nome = nome;
            this.desc = desc;
            this.passiva = passiva;
            this.lider1 = lider1;
            this.lider2 = lider2;
            this.lider3 = lider3;
            this.lider4 = lider4;
        }

        public override string ToString()
        {
            return $"Id: {id}\nNome: {nome}\nLore: {desc}\nPassiva: {passiva}\nLider +1: {lider1}\nLider +2: {lider2}\nLider +3: {lider3}\nLider +4: {lider4}\n";
        }
    }
}