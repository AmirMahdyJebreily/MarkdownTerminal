using MarkdownTerminal.Tools;

namespace MarkdownTerminal;

public static class MDComponents
{
    public static string Heading(this string plainText, int grade)
    {
        string preRes = $"   {("").PadRight(grade, '#')
                        .Colorize(249)
                        .Decorate(UniTextDecoration.Dim)} ";
        string res = plainText.Decorate(UniTextDecoration.Bold);
        if ((grade != 1))
        {
            return preRes + res.Colorize(257 - (grade * 2)); // Colorize the heading #{any but 1} text
        }
        return preRes + res.Decorate(UniTextDecoration.Underline).Colorize(231); // Colorize the heading #1 text
    }
    public static string Paragraph(this string plainText)
    {
        return " - ".Colorize(237) + plainText + "\n";
    }
    public static string MDBold(this string plainText)
    {
        return plainText.Colorize(231).Decorate(UniTextDecoration.Bold); // white
    }

    public static string MDItalic(this string plainText)
    {
        return plainText.Colorize(231).Decorate(UniTextDecoration.Italic); // white
    }

    public static string MDUnderline(this string plainText)
    {
        return plainText.Decorate(UniTextDecoration.Underline); // white
    }

    public static string MDStrikethrough(this string plainText)
    {
        return plainText.Decorate(UniTextDecoration.Strikethrough); // white
    }

    public static string MDQoute(this string plainText)
    {
        const int colorCode = 237;
        return $"█    {">".Colorize(240)} {plainText} ".Colorize(colorCode, UniColorGround.Background);

    }

}
