namespace MarkdownTerminal.Exceptions;

public class MdcatIOException : MdcatException
{
    private const string _message = "No such file exists";
    public MdcatIOException() : base(_message) { }
    public MdcatIOException(string message) : base($"{_message}: \'{message}\'") { }
}
