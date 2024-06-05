using MarkdownTerminal.Tools;

namespace MarkdownTerminal;

public static class MDComponents
{
    public static string Heading(this string plainText, int grade)
    {
        string res = $" {"".PadLeft(grade, '#').Colorize(UniColor.Gray)} {plainText.Colorize(UniColor.White).Decorate(UniTextDecoration.Bold)}";
        return $"{res}\n{"".PadRight(res.Length, '_')}";
    }
}
