using Core;

namespace Domain
{
    public class WordList : Entity
    {
        public WordList() {
            Words = new List<string>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public List<string> Words { get; set; }
        public bool Favourite { get; set; }
    }
}