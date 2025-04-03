using Spreadex.Drawing;
using Spreadex.Domain;

var widgets = new Widget[]
{
    new Rectangle { X = 30, Y = 50, Width = 30, Height = 40 },
    new Square { X = 15, Y = 30, Width = 35 },
    new Ellipse { X = 100, Y = 150, HorizontalDiameter = 300, VerticalDiameter = 200 },
    new Circle { X = 1, Y = 1, Diameter = 300 },
    new Textbox { X = 5, Y = 5, Width = 200, Height = 100, Text = "sample text" }
};

var drawing = new ConsoleDrawing(widgets);

drawing.Draw();