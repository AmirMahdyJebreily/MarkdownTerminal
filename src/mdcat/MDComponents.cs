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

        return $"{res}\n {("".PadRight(plainText.Length + grade + 5, '─')).Colorize(246)}";
    }
}
