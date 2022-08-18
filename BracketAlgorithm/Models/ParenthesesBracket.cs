namespace BracketAlgorithm.Models
{
    /// <summary>
    /// Круглые скобки
    /// </summary>
    public class ParenthesesBracket : Bracket
    {
        protected override char OpenBracket { get; set; } = '(';
        protected override char CloseBracket { get; set; } = ')';
    }
}
