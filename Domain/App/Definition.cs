using Core;

namespace Domain
{
    public class Definition : Entity
    {
        public Definition()
        {
            Synonyms = new List<string>();
            Antonyms = new List<string>();
        }
        public string DefinitionPhrase { get; set; }
        public string Example { get; set; }
        public List<string> Synonyms { get; set; }
        public List<string> Antonyms { get; set; }
    }
}