namespace D.D.Entities
{
    abstract public class Carta
    {
        public int id { get; set; } 
        public string nome { get; set; }
        public string desc { get; set; }

        protected Carta(int id,string nome, string desc)
        {
            this.id = id;
            this.nome = nome;
            this.desc = desc;
        }
        protected Carta() { }

        public override string ToString()
        {
            return $"Id: {id}\nNome: {nome}\nDescrição: {desc}";
        }
    }
}
