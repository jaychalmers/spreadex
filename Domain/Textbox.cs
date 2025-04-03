namespace Spreadex.Domain
{
    public class Textbox : Rectangle
    {
        public required string Text { get; init; }

        public override string Name => nameof(Textbox);
    }
}
