using System.Collections.Generic;
using System.Linq;

namespace MatchBrackets
{
    public static class MatchBrackets
    {
        private const string IgnoreCharacters = "\t\r\n";

        public static string ProcessText(string formula)
        {
            if (string.IsNullOrWhiteSpace(formula)) return formula;
            
            var currentLevel = 0;

            var bracketContents = new List<BracketContent>();
            var currentBracketContent = bracketContents.CreateNewContentLine(currentLevel);
            
            currentBracketContent.level = 0;
            foreach(var character in formula)
            {
                if (IgnoreCharacters.Contains(character)) continue;

                if (character == '(')
                {
                    currentLevel++;
                    //place the bracket on the next line by itself
                    bracketContents.AddBracketLine(currentLevel,"(");
                    
                    currentBracketContent = bracketContents.CreateNewContentLine(currentLevel);
                }
                else if (character == ')')
                {

                    //place the bracket on the next line by itself
                    bracketContents.AddBracketLine(currentLevel, ")");
                    
                    currentLevel--;
                    currentBracketContent=bracketContents.CreateNewContentLine(currentLevel);
                }                
                else
                {
                    currentBracketContent.contents += character.ToString();
                }
            }

            return Formatter.Format(bracketContents);
        }

       
    }
}
