using System.Collections.Generic;
using System.Text;

namespace MatchBrackets
{
    public static class Formatter
    {
        public static string Format(IEnumerable<BracketContent> bracketContents)
        {
            var sbResult = new StringBuilder(); 
            
            foreach(var bracketContent in bracketContents)
            {
                var padLeft = "";
                if (bracketContent.level > 0)
                {                    
                    padLeft = "".PadLeft(bracketContent.level,'\t');
                }
                
                sbResult.AppendLine($"{padLeft}{bracketContent.contents.TrimStart()}");
                
            }

            return sbResult.ToString();
        }


    }
}
