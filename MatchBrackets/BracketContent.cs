namespace MatchBrackets
{
    public class BracketContent
    {
        public int Level { get; set; }
        public string Contents { get; set; } = "";

        public override string ToString()
        {
            const int previewLength=25;
            return $"{Level}:{Contents.PadRight(previewLength).Substring(0, previewLength).Trim()}";
        }
    }
}
