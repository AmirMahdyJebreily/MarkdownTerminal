using System.IO;
using MarkdownTerminal.Exceptions;

namespace MarkdownTerminal;

public class mdcat
{
    public static void Main(string[] args)
    {
        try
        {

            if (args.Length == 0)
            {
                throw new MdcatIOException();
            }
            else
            {

            }
        }
        catch (MdcatIOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}