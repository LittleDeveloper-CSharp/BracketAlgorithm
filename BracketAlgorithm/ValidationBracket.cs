using BracketAlgorithm.Models;
using System.Collections.Generic;

namespace BracketAlgorithm
{
    /// <summary>
    /// Валидация скобок
    /// </summary>
    public class ValidationBracket
    {
        /// <summary>
        /// Проверяет наличие закрывающийся скобок в нужных местах
        /// </summary>
        /// <param name="lineBrackets">Строчка с скобками</param>
        /// <returns></returns>
        public bool ValidationBrackes(string lineBrackets)
        {
            var bracketStack = new Stack<Bracket>();
            var bracketFactory = new BracketFactory();

            foreach (var bracketChar in lineBrackets)
            {
                var bracket = bracketFactory.CreateBracket(bracketChar);

                if (bracket == null)
                {
                    var openBracket = bracketStack.Peek();

                    if (!openBracket.IsClosingBracket(bracketChar))
                        return false;

                    bracketStack.Pop();
                }
                else
                {
                    bracketStack.Push(bracket);
                }

                if (bracketStack.Count == 0)
                    return false;
            }

            if (bracketStack.Count > 0)
                return false;

            return true;
        }
    }
}
