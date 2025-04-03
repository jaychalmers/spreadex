using Spreadex.Domain;

namespace Spreadex.Drawing
{
    /// <summary>
    /// Renders widgets through Console in briefed format with title, etc.
    /// </summary>
    /// <param name="widgets"></param>
    public class ConsoleDrawing(IEnumerable<Widget> widgets) : Drawing(widgets)
    {                
        public override void Draw()
        {
            Console.WriteLine(Divider);
            Console.WriteLine(Title);
            Console.WriteLine(Divider);
            foreach (var widget in Widgets)
            {
                Console.WriteLine(_renderer.Render(widget));
            }
            Console.WriteLine(Divider);
        }

        private const string Divider = "----------------------------------------------------------------";
        private const string Title = "Requested Drawing";

        private readonly StringWidgetRenderer _renderer = new StringWidgetRenderer();
    }
}
