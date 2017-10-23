namespace MatchingParenthesis
{
    public class Matching
    {
        public bool hasMatches(string str)
        {
            //remove characters other than parenthesis
            char[] chars = str.ToCharArray();
            int posChar = 0;
            int removedCount = 0;
            foreach (char ch in chars)
            {
                posChar++;
                if (ch.ToString() != "(" && ch.ToString() != ")")
                {
                    str = str.Remove(posChar - removedCount - 1, 1);
                    removedCount++;
                }
            }

            bool hasMatch = DoWork(str);

            return hasMatch;
        }

        public bool DoWork(string str)
        {
            char[] pars = str.ToCharArray();

            int leftpos = 0;
            bool hasleftPar = false;
            bool hasrightPar = false;
            bool result = false;

            foreach (char ch in pars)
            {
                leftpos++;
                if (ch.ToString() == "(")
                {
                    hasleftPar = true;
                    string substr = str.Substring(leftpos, str.Length - leftpos);

                    int rightpos = leftpos;
                    char[] subchars = substr.ToCharArray();
                    foreach (char subch in subchars)
                    {
                        rightpos++;
                        if (subch.ToString() == ")")
                        {
                            hasrightPar = true;
                            str = str.Remove(leftpos - 1, 1);
                            str = str.Remove(rightpos - 2, 1);
                            break;
                        }
                    }
                }

                if (hasleftPar && hasrightPar)
                {
                    if (str.Length == 0)
                        result = true;
                    else
                        return DoWork(str);
                }

            }

            return result;
        }
    }
}
