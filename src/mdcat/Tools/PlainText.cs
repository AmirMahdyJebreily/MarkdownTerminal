using System.Collections.Generic;

namespace MarkdownTerminal.Tools;

public enum UniColorGround
{
    Foreground = 38,
    Background = 48
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
    White = 231
}

public enum UniTextDecoration
{
    Bold = 1,
    Dim = 2,
    Italic = 3,
    Underline = 4,
    Blink = 5
}

public static class PlainText
{
    const string reset = "\u001b[0m";
    private static string _decorate(UniTextDecoration code)
    {
        return $"\u001b[{(int)code}m";
    }
    private static string _color(int code, int groundCode = 30)
    {
        return $"\u001b[{groundCode};5;{code}m";
    } // Generate unicode by color code

    public static string Colorize(this string plainText, int colorCode, UniColorGround ground = UniColorGround.Foreground, bool background = false)
    {
        return $"{_color(colorCode, (int)ground)}{plainText}{reset}";
    }

    public static string Decorate(this string plainText, UniTextDecoration decorCode)
    {
        return $"{_decorate(decorCode)}{plainText}{reset}";
    }
}
