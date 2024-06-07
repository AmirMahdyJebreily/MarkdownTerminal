using System.IO;
using MarkdownTerminal.Exceptions;

namespace MarkdownTerminal;

public class mdcat
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(MDComponents.Heading("Kos Madar Besat", 1));
            Console.WriteLine(MDComponents.Heading("Kos Madar Besat", 2));
            Console.WriteLine(MDComponents.Heading("Kos Madar Besat", 3));
            Console.WriteLine(MDComponents.Heading("Kos Madar Besat", 4));
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