using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchBrackets
{
    public static class BracketContents
    {


        public static void AddBracketLine(this List<BracketContent> bracketContents, int level, string content)
        {
            var nextLine = new BracketContent { level = level, contents = "(" };
            bracketContents.Add(nextLine);
        }

        public static BracketContent CreateNewContentLine(this List<BracketContent> bracketContents, int level)
        {
            var bracketContent = new BracketContent { level = level };

            bracketContents.Add(bracketContent);

            return bracketContent;
        }

    }
}
