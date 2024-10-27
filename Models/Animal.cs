namespace Animals2.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public string SoundUrl { get; set; }
        protected Animal(string name, string sound, string soundUrl)
        {
            Name = name;
            Sound = sound;
            SoundUrl = soundUrl;
        }
        public abstract string NameDisplay(string name);
        public abstract string SoundDisplay(string sound);
        public abstract string SoundUrlDisplay(string soundUrl);
    }
}
