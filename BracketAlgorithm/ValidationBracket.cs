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
        public bool ValidationBraces(string lineBrackets)
        {
            var bracketStack = new Stack<Bracket>();
            var bracketFactory = new BracketFactory();

            foreach (var separatorChar in lineBrackets)
            {
                var bracket = bracketFactory.CreateBracket(separatorChar);

                if (bracket == null)
                {
                    var openBracket = bracketStack.Peek();

                    if (!openBracket.IsClosingBracket(separatorChar))
                        return false;

                    bracketStack.Pop();
                }
                else
                {
                    bracketStack.Push(bracket);
                }
            }

            return true;
        }
    }
}
