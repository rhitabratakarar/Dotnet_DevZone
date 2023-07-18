using Practice.Interfaces;

namespace Practice.Classes
{
    internal class BracketChecker : IBracketChecker
    {
        private Stack<char> stack = new Stack<char>();
        IList<char> openingBracs = new List<char>() { '(', '{', '[' };
        IList<char> closingBracs = new List<char>() { ')', '}', ']' };

        private char GetCorrespondingOpeningBracket(char closingBrac)
        {
            int closingBrackInd = this.closingBracs.IndexOf(closingBrac);
            return this.openingBracs[closingBrackInd];
        }

        public bool CheckBracketPair(string text)
        {
            bool isValid = true;
            IList<char> brackets = new List<char>(text);

            foreach (char brac in brackets)
            {
                if (openingBracs.Contains(brac))
                {
                    stack.Push(brac);
                }
                if (closingBracs.Contains(brac))
                {
                    char correspondingOpeningBrac = GetCorrespondingOpeningBracket(brac);
                    try
                    {
                        char poppedBrac = stack.Pop();
                        if (poppedBrac != correspondingOpeningBrac)
                        {
                            return false;
                        }
                    }
                    catch (System.InvalidOperationException)
                    {
                        return false;
                    }
                }
            }
            return isValid && stack.ToArray().Length == 0;
        }
    }
}
