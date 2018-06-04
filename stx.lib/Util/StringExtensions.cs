using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace stx.lib.Util
{
    public static class StringExtensions
    {
        public static string ToCommaDelimited(this IEnumerable<string> strings)
        {
            if (strings == null)
                return string.Empty;
            return string.Join(",", strings);
        }

        public static IEnumerable<string> GetLines(this string str, bool removeEmptyLines = false)
        {
            using (var sr = new StringReader(str))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (removeEmptyLines && String.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    yield return line;
                }
            }
        }
    }
}
