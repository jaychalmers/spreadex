using Spreadex.Domain;

namespace Spreadex.Drawing
{
    /// <summary>
    /// "Renders" a Widget to a different type.
    /// </summary>
    /// <typeparam name="T">The type to convert the widget to.</typeparam>
    public interface IWidgetRenderer<T>
    {
        public T Render(Widget obj);
    }
}
