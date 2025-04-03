using Spreadex.Domain;

namespace Spreadex.Exceptions;

public class UnsupportedWidgetException(Widget widget) : Exception($"Unsupported Widget Type: {widget.Name}");
