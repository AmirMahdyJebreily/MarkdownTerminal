using System.Collections.Generic;

namespace MarkdownTerminal.Tools;

public enum UniColor
{
    // This Color codes for unicode like: \u001b[3{ color code }m
    Black = 0, 
    Red = 1,
    Green = 2,
    Yellow = 3,
    Blue = 4,
    Magenta = 5,
    Cyan = 6,
    White = 7
}

public enum UniTextDecoration
{
    Bold = 1,
    Underline = 4,
    Blink = 5
}

public static class PlainText
{
    private static string _decorate(UniTextDecoration code)
    {
        return $"\u001b[{(int)code}m";
    }
    private static string _foreColor(int code)
    {
        if (code >= 0 && code <= 7)
            return $"\u001b[3{code}m";
        return $"\u001b[3{(int)UniColor.White}m";
    } // Generate unicode by color code for foreground color

    private static string _backColor(int code)
    {
        if (code >= 0 && code <= 7)
            return $"\u001b[4{code}m";
        return $"\u001b[4{(int)UniColor.Black}m";
    } // Generate unicode by color code for background color

    public static string Colorize(this string plainText, int colorCode, bool background = false)
    {
        Func<int, string> colorUni = (int code) => (background) ? _backColor(code) : _foreColor(code);
        return $"{colorUni(colorCode)}{plainText}{colorUni(7)}";
    }
}
