using D.D.Entities;
using D.D.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.D.Modelos
{
    public class Campo : Magica
    {
        public List<Atributos> bonus = new List<Atributos>() ;
        public List<Atributos> maleficio = new List<Atributos>();
        public string bonusEfeito { get; set; }
        public string bonusMaleficio { get; set; }

        public Campo(int id, string nome, string desc, string efeito,List<Atributos> bonus, List<Atributos> maleficio, string bonusEfeito, string bonusMaleficio) : base (id,nome,desc,efeito)
        {
            this.bonus.AddRange(bonus);
            this.maleficio.AddRange(maleficio);
            this.bonusEfeito = bonusEfeito;
            this.bonusMaleficio = bonusMaleficio;
        }

        public sealed override string ToString()
        {
            return $"{base.ToString()}\nModelo: Campo\nBeneficios: {string.Join(", ",bonus)}\nMaleficios: {string.Join(", ", maleficio)}\nEf.Bonus: {bonusEfeito}\nEf.Maleficio: {bonusMaleficio}\n-----";
        }
    }
}
