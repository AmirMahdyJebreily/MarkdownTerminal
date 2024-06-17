namespace MarkdownTerminal.Tools;
#region Enums
public enum UniColorGround
{
    Foreground = 3,
    Background = 4
}
public enum UniColor
{
    // This Color codes for unicode like: \u001b[3{ color code }m
    Black = 232,
    Gray = 238,
    Red = 197,
    Green = 47,
    Yellow = 226,
    Blue = 4,
    Cyan = 51,
    White = 231,
}

public enum UniTextDecoration
{
    Bold = 1,
    Dim = 2,
    Italic = 3,
    Strikethrough = 9,
    Underline = 4,
    Blink = 5
}
#endregion

public static class PlainText
{
    #region Constants
    const string _reset = "\u001b[0m";
    const string _resetForeColor = "\u001b[39m";
    const string _resetBackColor = "\u001b[49m";
    #endregion

    #region Private core functions
    private static string _decorate(UniTextDecoration code)
    {
        return $"\u001b[{(int)code}m";
    }
    private static string _color(int code, int groundCode = 3)
    {
        return $"\u001b[{groundCode}8;5;{code}m";
    } // Generate unicode by color code
    #endregion

    #region Public functions
    public static string DecorateReset(UniTextDecoration code)
    {
        int intcode = (int)code;
        if (intcode == 1)
            intcode = 2;
        return $"\u001b[2{intcode}m";
    }
    public static string ColorReset(UniColorGround ground = UniColorGround.Foreground)
    {
        return ((ground == UniColorGround.Foreground) ? _resetForeColor : _resetBackColor);
    }
    public static string Colorize(this string plainText, int colorCode, UniColorGround ground = UniColorGround.Foreground)
    {
        return $"{_color(colorCode, (int)ground)}{plainText}{ColorReset(ground)}";
    }

    public static string Decorate(this string plainText, UniTextDecoration decorCode)
    {
        return $"{_decorate(decorCode)}{plainText}{DecorateReset(decorCode)}";
    }
    #endregion
}
