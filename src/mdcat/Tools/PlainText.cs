using System.Collections.Generic;

namespace MarkdownTerminal.Tools;

public enum UniColorGround
{
    Foreground = 30,
    Background = 40
}
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
    const string reset = "\u001b[0m";
    private static string _decorate(UniTextDecoration code)
    {
        return $"\u001b[{(int)code}m";
    }
    private static string _color(int code, int groundCode = 30)
    {
        if (code >= 0 && code <= 7)
            return $"\u001b[3{code}m";
        return $"\u001b[{groundCode + (int)UniColor.White}m";
    } // Generate unicode by color code for foreground color

    public static string Colorize(this string plainText, UniColor colorCode, UniColorGround ground = UniColorGround.Foreground, bool background = false)
    {
        return $"{_color((int)colorCode, (int)ground)}{plainText}{reset}";
    }

    public static string Decorate(this string plainText, UniTextDecoration decorCode)
    {
        return $"{_decorate(decorCode)}{plainText}{reset}";
    }
}
