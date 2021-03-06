﻿using System.Collections.Generic;
using System.Linq;

namespace MatchBrackets
{
    public static class BracketContents
    {

        public static void AddBracketLine(this List<BracketContent> bracketContents, int level, string content)
        {
            var nextLine = new BracketContent { Level = level, Contents = content };
            bracketContents.Add(nextLine);
        }

        public static BracketContent CreateNewContentLine(this List<BracketContent> bracketContents, int level)
        {
            var bracketContent = new BracketContent { Level = level };

            bracketContents.Add(bracketContent);

            return bracketContent;
        }

        public static int DeepestLevel(this IEnumerable<BracketContent> bracketContents)
            => bracketContents?.Max(x => x.Level)??0;
    }
}
