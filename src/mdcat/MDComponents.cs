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
        string reset = "".Decorate(UniTextDecoration.Bold, "");
        if ((grade != 1))
        {
            reset = reset.Colorize(257 - (grade * 2), UniColorGround.Foreground, "");
            return preRes + res.reseter(reset).Colorize(257 - (grade * 2)); // Colorize the heading #{any but 1} text
        }
        reset = reset.Decorate(UniTextDecoration.Underline, "").Colorize(231, UniColorGround.Foreground, "");
        return preRes + res.reseter(reset).Decorate(UniTextDecoration.Underline).Colorize(231); // Colorize the heading #1 text
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
        string reset = "".Colorize(colorCode, UniColorGround.Background, "");
        return $"█    {">".Colorize(240)} {plainText} ".reseter(reset).Colorize(colorCode, UniColorGround.Background);

    }

}
