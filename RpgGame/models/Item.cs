namespace RpgGame.models
{
    public abstract class Item
    {
        public string nome { get; protected set; }
        public string? desc { get; protected set; }
    }
}
