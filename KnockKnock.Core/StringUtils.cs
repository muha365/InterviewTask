using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KnockKnock.Core
{
    public static class StringUtils
    {
        //match any word characters or and some special characters
        static Regex rgx = new Regex(@"([^\s\r\n]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.CultureInvariant);

        private static string evaluator(Match input)
        {
            var x = new string(input.Value.ToCharArray().Reverse().ToArray());
            return x;
        }

        /// <summary>
        /// reverse words in sentences
        /// </summary>
        /// <param name="s"> the sentence you will reverse its words</param>
        /// <returns></returns>
        public static string ReverseString(this string s)
        {
            if (s == null || s.Contains(@"\"))
            {
                throw new ArgumentNullException(nameof(s), "Value cannot be null");
            }
            if (s == string.Empty)
            {
                return s;
            }
             
            // replace the matched results with its reversed chars
            var matches = rgx.Replace(s, evaluator);
            return matches;
        }

    }
}
