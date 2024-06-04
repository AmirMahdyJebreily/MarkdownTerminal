namespace MarkdownTerminal.Exceptions;

public class MdcatException : Exception
{
    private const string _message = "mdcat error";
    public MdcatException() : base(_message) { }
    public MdcatException(string message) : base($"[\u001b[31m{_message.ToUpper()}\u001b[37m] \'{message}\'") { }
}
