﻿using System.IO;
using MarkdownTerminal.Exceptions;

namespace MarkdownTerminal;

public class mdcat
{
    public static void Main(string[] args)
    {
        try
        {
            string h1 = MDComponents.Heading("Kos " + "Madar".MDItalic() + " Besat", 1);
            Console.WriteLine(h1);
            Console.WriteLine(MDComponents.Paragraph($"Madar besat was a {"whore".MDBold()} in mashhad, stari st no.13"));
            Console.WriteLine(MDComponents.Heading("Kos Madar Besat", 2));
            Console.WriteLine(MDComponents.MDQoute($"Madar besat was a {"whore".MDItalic()} in mashhad, stari st no.13"));
        }
        catch (MdcatIOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}