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
                if (bracketContent.Level > 0)
                {                    
                    padLeft = "".PadLeft(bracketContent.Level,'\t');
                }
                
                sbResult.AppendLine($"{padLeft}{bracketContent.Contents.TrimStart()}");
                
            }

            return sbResult.ToString();
        }


    }
}
