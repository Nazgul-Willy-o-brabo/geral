namespace RpgGame.models
{
    public abstract class ItemEquipavel: Item
    {
        public double ItemMult { get; protected set; }
        public int TypeClass { get; protected set; }
    }
}
