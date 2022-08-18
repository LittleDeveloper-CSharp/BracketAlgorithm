namespace BracketAlgorithm.Models
{
    /// <summary>
    /// Фигурные скобки
    /// </summary>
    public class СurlyBracket : Bracket
    {
        protected override char OpenBracket { get; set; } = '{';
        protected override char CloseBracket { get; set; } = '}';
    }
}
