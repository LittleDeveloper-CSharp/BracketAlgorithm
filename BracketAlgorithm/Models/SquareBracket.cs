namespace BracketAlgorithm.Models
{
    /// <summary>
    /// Квадратные скобки
    /// </summary>
    public class SquareBracket : Bracket
    {
        protected override char OpenBracket { get; set; } = '[';
        protected override char CloseBracket { get; set; } = ']';
    }
}
