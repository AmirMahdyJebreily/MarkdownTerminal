using MarkdownTerminal.Tools;

namespace MarkdownTerminal;

public static class MDComponents
{
    private static Func<string, string> _mdSynTheme = plainText => plainText.Colorize(249).Decorate(UniTextDecoration.Dim);
    public static string Heading(this string plainText, int grade, bool mdSyntax = true)
    {
        string mdSyn = (mdSyntax) ? $"   {_mdSynTheme(("").PadRight(grade, '#'))} " : "   ";
        string res = plainText.Decorate(UniTextDecoration.Bold);
        if ((grade != 1))
        {
            return mdSyn + res.Colorize(257 - (grade * 2)); // Colorize the heading #{any but 1} text
        }
        return mdSyn + res.Decorate(UniTextDecoration.Underline).Colorize(231); // Colorize the heading #1 text
    }
    public static string Paragraph(this string plainText, bool mdSyntax = true)
    {
        return ((mdSyntax) ? " - ".Colorize(237) : "") + plainText + "\n";
    }
    public static string MDBold(this string plainText, bool mdSyntax = true)
    {
        string mdSyn = (mdSyntax) ? _mdSynTheme("**") : "";
        return mdSyn + plainText.Decorate(UniTextDecoration.Bold) + mdSyn; // white
    }

    public static string MDItalic(this string plainText, bool mdSyntax = true)
    {
        string mdSyn = (mdSyntax) ? _mdSynTheme("*") : "";
        return mdSyn + plainText.Decorate(UniTextDecoration.Italic) + mdSyn; // white
    }

    public static string MDUnderline(this string plainText, bool mdSyntax = true)
    {
        string mdSyn = (mdSyntax) ? _mdSynTheme("_") : "";
        return mdSyn + plainText.Decorate(UniTextDecoration.Underline) + mdSyn; // white
    }

    public static string MDStrikethrough(this string plainText, bool mdSyntax = true)
    {
        string mdSyn = (mdSyntax) ? _mdSynTheme("~~") : "";
        return mdSyn + plainText.Decorate(UniTextDecoration.Strikethrough) + mdSyn; // white
    }

    public static string MDQoute(this string plainText, bool mdSyntax = true)
    {
        string mdSyn = (mdSyntax) ? _mdSynTheme(">") : "";
        return $"█    {mdSyn} {plainText} ".Colorize(237, UniColorGround.Background);
    }

    public static string MdInlineCode(this string plainText, bool mdSyntax = true)
    {
        string mdSyn = (mdSyntax) ? _mdSynTheme("`") : "";
        return mdSyn + plainText.Colorize(210) + mdSyn;
    }

    public static string MdCodeBlock(this string plainText, string lang = "", bool mdSyntax = true)
    {
        string mdSyn = (mdSyntax) ? _mdSynTheme("```") : "";
        string mdSynSec = (mdSyntax) ? _mdSynTheme(lang) : "";
        return $"\n   {mdSyn}{mdSynSec}\n\t{plainText}\n   {mdSyn}\n";
    }

}
