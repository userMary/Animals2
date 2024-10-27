namespace Animals2.Models
{
    public class Dog : Animal
    {
        public Dog(string name, string sound, string soundUrl) : base(name, sound, soundUrl) { }
        public override string NameDisplay(string name)
        {
            return name;
        }
        public override string SoundDisplay(string sound)
        {
            return sound;
        }
        public override string SoundUrlDisplay(string soundUrl)
        {
            return soundUrl;
        }
    }
}
