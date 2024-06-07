using  MarkdownTerminal.Tools;
namespace MarkdownTerminal.Exceptions;

public class MdcatException : Exception
{
    private const string _message = "mdcat error";
    public MdcatException() : base(_message) { }
    public MdcatException(string message) : base($"[{_message.ToUpper().Colorize((int)UniColor.Red).Decorate(UniTextDecoration.Bold)}] \'{message}\'") { }
}
