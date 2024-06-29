using MarkdownTerminal.Tools;
using System.Text.RegularExpressions;

namespace MarkdownTerminal;

public static class MDComponents
{
    public static string StyleLine(this string content, Func<string, string>? commponent, int check = 0)
    {

        if (Regex.IsMatch(content, "(#) .*") && commponent != Heading)
            return StyleLine(content, Heading);


        return commponent(content) ?? content;
    }



    private static Func<string, string> _mdSynTheme = plainText => plainText.Colorize(249).Decorate(UniTextDecoration.Dim);

    public static string Heading(this string content)
    {
        string sharps = _mdSynTheme(Regex.Match(content, "#*").Value);
        return $"\n {sharps + content.Replace("#", "").Colorize(231).Decorate(UniTextDecoration.Bold)}";

    }
    public static string Paragraph(this string plainText, bool mdSyntax = true)
    {
        return ((mdSyntax) ? "   - ".Colorize(237) : "") + plainText + "\n";
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
        return $"\n   {mdSyn}{mdSynSec}\n\t{plainText.Colorize(249)}\n   {mdSyn}\n";
    }

    //public static string MDLink(this string plainText)
    //{

    //}

}
