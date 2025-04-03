using Spreadex.Domain;

namespace Spreadex.Drawing
{
    /// <summary>
    /// Corrals a collection of Widgets for rendering.
    /// </summary>
    /// <remarks>
    /// Possibly YAGNI, but pre-emptive abstraction around different kinds of renderer.
    /// </remarks>
    public abstract class Drawing(IEnumerable<Widget> widgets)
    {
        public IEnumerable<Widget> Widgets { get; } = widgets;

        public abstract void Draw();
    }
}
