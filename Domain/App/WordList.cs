using Core;

namespace Domain
{
    public class WordList : Entity
    {
        public WordList() {
            Words = new List<RootWord>();
        }
        public string Name { get; set; }
        public User User { get; set; }
        public List<RootWord> Words { get; set; }
        public bool Favourite { get; set; }
    }
}