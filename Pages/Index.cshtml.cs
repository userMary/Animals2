using Animals2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Animals2.Pages
{
    public class IndexModel : PageModel
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public IndexModel() { }
        public void OnGet()
        {
            Animals = new List<Animal>
            {
                new Dog("Dog", "Woof", "/audio/dog.mp3"),
                new Dog("Cat", "Meow", "/audio/cat.mp3"),
                new Dog("Cow", "Moo", "/audio/cow.mp3"),
                new Dog("Duck", "Quack", "/audio/duck.mp3"),
                new Dog("Horse", "Neigh", "/audio/horse.mp3"),
                new Dog("Lion", "Roar", "/audio/lion.mp3"),
                new Dog("Sheep", "Baa", "/audio/sheep.mp3"),
                new Dog("Elephant", "Trumpet", "/audio/elephant.mp3"),
                new Dog("Frog", "Ribbit", "/audio/frog.mp3")
            };
        }
    }
}
