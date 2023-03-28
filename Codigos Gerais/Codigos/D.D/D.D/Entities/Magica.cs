namespace D.D.Entities
{
    abstract public class Magica : Carta
    {
        public string efeito { get; set; }
        protected Magica(int id, string nome, string desc, string efeito) : base (id,nome,desc) 
        { this.efeito = efeito; }
        protected Magica() { }


        public override string ToString()
        {
            return $"{base.ToString()}\nTipo: Mágica\nEfeito: {efeito}";
        }
    }

}
