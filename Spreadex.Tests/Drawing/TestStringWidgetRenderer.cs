using AutoFixture.Xunit2;
using FluentAssertions;
using Spreadex.Domain;
using Spreadex.Drawing;
using Spreadex.Exceptions;

namespace Spreadex.Tests.Drawing
{
    public class TestStringWidgetRenderer
    {
        [Theory, AutoData]
        public void StringWidgetRenderer_Render_TextboxIsRenderedCorrectly(StringWidgetRenderer sut)
        {
            // Arrange
            var textbox = new Textbox
            {
                X = 1,
                Y = 2,
                Width = 3,
                Height = 4,
                Text = "placeholder"
            };

            // Act
            var result = sut.Render(textbox);

            // Assert
            result.Should().Be("Textbox (1,2) width=3 height=4 text=\"placeholder\"");
        }

        [Theory, AutoData]
        public void StringWidgetRenderer_Render_SquareIsRenderedCorrectly(StringWidgetRenderer sut)
        {
            // Arrange
            var square = new Square
            {
                X = 1,
                Y = 2,
                Width = 3
            };

            // Act
            var result = sut.Render(square);

            // Assert
            result.Should().Be("Square (1,2) size=3");
        }

        [Theory, AutoData]
        public void StringWidgetRenderer_Render_RectangleIsRenderedCorrectly(StringWidgetRenderer sut)
        {
            // Arrange
            var rectangle = new Rectangle
            {
                X = 1,
                Y = 2,
                Width = 3,
                Height = 4
            };

            // Act
            var result = sut.Render(rectangle);

            // Assert
            result.Should().Be("Rectangle (1,2) width=3 height=4");
        }

        [Theory, AutoData]
        public void StringWidgetRenderer_Render_CircleIsRenderedCorrectly(StringWidgetRenderer sut)
        {
            // Arrange
            var circle = new Circle
            {
                X = 1,
                Y = 2,
                Diameter = 3
            };

            // Act
            var result = sut.Render(circle);

            // Assert
            result.Should().Be("Circle (1,2) size=3");
        }

        [Theory, AutoData]
        public void StringWidgetRenderer_Render_EllipseIsRenderedCorrectly(StringWidgetRenderer sut)
        {
            // Arrange
            var ellipse = new Ellipse
            {
                X = 1,
                Y = 2,
                HorizontalDiameter = 3,
                VerticalDiameter = 4
            };

            // Act
            var result = sut.Render(ellipse);

            // Assert
            result.Should().Be("Ellipse (1,2) diameterH = 3 diameterV = 4");
        }

        [Theory, AutoData]
        public void StringWidgetRenderer_Render_ThrowsWithUnsupportedWidget(StringWidgetRenderer sut)
        {
            // Arrange
            var fake = new FakeWidget
            {
                X = 1,
                Y = 2
            };

            // Act & Assert
            sut.Invoking(x => x.Render(fake))
                .Should().Throw<UnsupportedWidgetException>()
                .WithMessage("Unsupported Widget Type: Fake");
        }

        private class FakeWidget : Widget
        {
            public override string Name => "Fake";
        }
    }
}
