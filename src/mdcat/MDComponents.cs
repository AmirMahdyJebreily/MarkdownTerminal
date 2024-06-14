using MarkdownTerminal.Tools;

namespace MarkdownTerminal;

public static class MDComponents
{
    public static string Heading(this string plainText, int grade)
    {
        string res = $"  {
             ("").PadRight(grade, '#')
            .Colorize(249) 
            .Decorate(UniTextDecoration.Dim)} { // Colosize and decorate #'s before the heading text
             plainText
            .Colorize((grade == 1) ? 231 : 257 - (grade * 2))
            .Decorate(UniTextDecoration.Bold)}"; // Colorize the heading text

        return $"\n{res}\n";
    }
    public static string Paragraph(this string plainText)
    {
        return " - ".Decorate(UniTextDecoration.Dim) + plainText;
    }
    public static string MDBold(this string plainText)
    {
        return plainText.Colorize(231).Decorate(UniTextDecoration.Bold); // white
    }
}
