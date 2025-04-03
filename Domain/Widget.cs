namespace Spreadex.Domain
{
    /// <summary>
    /// Core Widget object, for rendering any type of shape.
    /// </summary>
    public abstract class Widget
    {
        public required virtual int X { get; init; }

        public required virtual int Y { get; init; }

        public abstract string Name { get; }
    }
}
