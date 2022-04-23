using Core;

namespace Domain
{
    public class Meaning : Entity
    {
        public Meaning()
        {
            Definitions = new List<Definition>();
        }
        public string PartOfSpeech { get; set; }
        public List<Definition> Definitions { get; set; }
    }
}