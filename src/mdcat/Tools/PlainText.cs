using System.Collections.Generic;

namespace MarkdownTerminal.Tools;

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
    White = 231
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

public static class PlainText
{
    const string _reset = "\u001b[0m";
    private static string _decorate(UniTextDecoration code)
    {
        return $"\u001b[{(int)code}m";
    }
    private static string _color(int code, int groundCode = 3)
    {
        return $"\u001b[{groundCode}8;5;{code}m";
    } // Generate unicode by color code

    public static string Colorize(this string plainText, int colorCode, UniColorGround ground = UniColorGround.Foreground, string reset = "")
    {
        return $"{_color(colorCode, (int)ground)}{plainText}{_reset + reset}";
    }

    public static string Decorate(this string plainText, UniTextDecoration decorCode, string reset = "")
    {
        return $"{_decorate(decorCode)}{plainText}{_reset + reset}";
    }

    public static string reseter(this string plainText, string reset = _reset)
    {
        return plainText.Replace(_reset, _reset + reset);
    }
}
