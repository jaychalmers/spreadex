namespace Spreadex.Domain
{
    public class Square : Widget
    {
        public required uint Width { get; init; }

        public override string Name => nameof(Square);
    }
}
