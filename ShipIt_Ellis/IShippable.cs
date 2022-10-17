namespace ShipIt_Ellis
{
    public interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
