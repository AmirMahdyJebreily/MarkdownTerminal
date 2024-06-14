using MarkdownTerminal.Tools;

namespace MarkdownTerminal;

public static class MDComponents
{
    public static string Heading(this string plainText, int grade)
    {
        if ((grade != 1))
        {
            return $"   {("").PadRight(grade, '#')
                .Colorize(249)
                .Decorate(UniTextDecoration.Dim)} { // Colosize and decorate #'s before the heading text
                 plainText
                .Colorize(257 - (grade * 2))
                .Decorate(UniTextDecoration.Bold)}"; // Colorize the heading text
        }
        return $"\n   {("").PadRight(grade, '#')
                .Colorize(249)
                .Decorate(UniTextDecoration.Dim)} { // Colosize and decorate #'s before the heading text
                 plainText
                .Colorize(231)
                .Decorate(UniTextDecoration.Bold)}\n"; // Colorize the heading text

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
}
