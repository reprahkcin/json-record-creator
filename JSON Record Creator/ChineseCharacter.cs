using System.Collections.Generic;

namespace JSON_Record_Creator
{
    public class ChineseCharacter
    {
        public string id { get; set; }
        public List<string> chinese { get; set; }
        public List<string> romanized { get; set; }
        public List<int> importantCharacters { get; set; }
        public string englishTranslation { get; set; }
        public List<string> mainGraphics { get; set; }
        public List<string> strokeAudio { get; set; }
        public List<string> strokePng { get; set; }
        public string characterAnimated { get; set; }
        public string phraseAudio { get; set; }
        public string wordAudio { get; set; }
    }
}