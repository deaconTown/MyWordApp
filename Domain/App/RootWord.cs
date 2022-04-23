using Core;

namespace Domain
{
    public class RootWord : Entity
    {
        public RootWord()
        {
            Phonetics = new List<Phonetic>();
            Meanings = new List<Meaning>();
        }
        public string Word { get; set; }
        public string Phonetic { get; set; }
        public List<Phonetic> Phonetics { get; set; }
        public string Origin { get; set; }
        public List<Meaning> Meanings { get; set; }
    }
}