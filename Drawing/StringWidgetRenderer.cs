using Spreadex.Domain;
using Spreadex.Exceptions;

namespace Spreadex.Drawing
{
    /// <summary>
    /// Renders a <see cref="Widget"/> in a string representation.
    /// </summary>
    public class StringWidgetRenderer : IWidgetRenderer<string>
    {
        public string Render(Widget widget) => 
            $"{widget.Name} ({widget.X},{widget.Y}) {PropertySignature(widget)}";

        private string PropertySignature(Widget widget) => widget switch
        {
            Textbox t => $"width={t.Width} height={t.Height} text=\"{t.Text}\"",
            Square s => $"size={s.Width}",
            Rectangle r => $"width={r.Width} height={r.Height}",
            Circle c => $"size={c.Diameter}",
            Ellipse e => $"diameterH = {e.HorizontalDiameter} diameterV = {e.VerticalDiameter}",
            _ => throw new UnsupportedWidgetException(widget)
        };
    }
}
