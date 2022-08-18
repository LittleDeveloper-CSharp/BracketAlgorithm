namespace BracketAlgorithm.Models
{
    /// <summary>
    /// Фабрика скобок
    /// </summary>
    public class BracketFactory
    {
        /// <summary>
        /// Создать скобки
        /// </summary>
        /// <param name="openBracket">Открывающая скобка</param>
        /// <returns></returns>
        public Bracket? CreateBracket(char openBracket)
        {
            return openBracket switch
            {
                '(' => new ParenthesesBracket(),
                '{' => new СurlyBracket(),
                '[' => new SquareBracket(),
                _ => null
            };
        }
    }
}
