namespace BracketAlgorithm.Models
{
    /// <summary>
    /// Супер класс скобок
    /// </summary>
    public abstract class Bracket
    {
        /// <summary>
        /// Открывающая скобка
        /// </summary>
        protected abstract char OpenBracket { get; set; }

        /// <summary>
        /// Закрывающая скобка
        /// </summary>
        protected abstract char CloseBracket { get; set; }

        /// <summary>
        /// Проверка на соответствие, является ли входящая скобка - закрывающей
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        public bool IsClosingBracket(char bracket) => CloseBracket == bracket;
    }
}
