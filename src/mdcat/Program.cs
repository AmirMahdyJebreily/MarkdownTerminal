using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using MarkdownTerminal.Exceptions;

namespace MarkdownTerminal;

public class mdcat
{
    private static Stream _getStringFromWeb(string[] args)
    {
        var webRequest = (HttpWebRequest)HttpWebRequest.Create(args[0]);
        webRequest.UserAgent = "Hej";

        var response = webRequest.GetResponse();
        var content = response.GetResponseStream();

        return content;
    }
    private static Stream _getStringFromPath(string[] args)
    {
        string p = "";

        if (args.Length > 0)
        {
            if (args[0] == "")
            {
                throw new MdcatIOException("No address inputted");
            }
            p = Path.GetFullPath(args[0]);
        }
        else
        {
            Console.Write("Enter path to markdown file : ");
            p = Console.ReadLine() ?? "";

            if (!File.Exists(p))
            {
                throw new MdcatIOException();
            }
        }

        // There is no problem if non-.md files will be inputed
        FileStream fs = File.OpenRead(p);
        return fs;

    }
    public static void Main(string[] args)
    {
        try
        {
            using (StreamReader i = new StreamReader(_getStringFromPath(args)))
            {
                while (!i.EndOfStream)
                {
                    string line = i.ReadLine() ?? "";
                    Console.WriteLine(line.StyleLine((string a) => $"    {a}"));
                }
            }

        }
        catch (MdcatIOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}