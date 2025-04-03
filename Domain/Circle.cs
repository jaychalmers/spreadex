namespace Spreadex.Domain
{
    public class Circle : Widget
    {
        public required uint Diameter { get; init; }

        public override string Name => nameof(Circle);
    }
}
