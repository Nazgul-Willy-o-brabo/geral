using RpgGame.models;
using RpgGame.Interface;

namespace RpgGame.itens
{
    internal class AdagaDaMorte : ItemEquipavel, IMorte
    {
        public AdagaDaMorte()
        {
            nome = "Adagas da morte";
            ItemMult = 1.4;
            Id = 11;
            TypeClass = 3;
        }
        public void Death()
        {
            
        }
    }
}
