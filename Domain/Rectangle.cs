namespace Spreadex.Domain
{
    public class Rectangle : Widget
    {
        public required uint Width { get; init; }

        public required uint Height { get; init; }

        public override string Name => nameof(Rectangle);
    }
}
