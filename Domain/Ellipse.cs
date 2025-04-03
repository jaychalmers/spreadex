namespace Spreadex.Domain
{
    public class Ellipse : Widget
    {
        public required uint HorizontalDiameter { get; init; }

        public required uint VerticalDiameter { get; init; }

        public override string Name => nameof(Ellipse);
    }
}
