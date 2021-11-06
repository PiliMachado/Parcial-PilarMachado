namespace Ucu.Poo.Defense
{
    public class MaterialType
    {
        public string Name { get; set; }

        public bool IsDangerous { get; set; }

        public MaterialType(string name, bool IsDangerous)
        {
            this.Name = name;
            this.IsDangerous = IsDangerous;
        }
    }
}