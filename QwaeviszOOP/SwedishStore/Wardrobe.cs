namespace SwedishStore
{
    internal class Wardrobe : Furniture, BuildInLampCapable
    {
        private int numberOfShelves;

        private bool buildInLamp;

        public int NumberOfShelves
        {
            get { return this.numberOfShelves; }
        }

        public Wardrobe(string name, int price, Room room, Dimension dimension, bool buildInLamp, int numberOfShelves) : base(name, price, room, dimension)
        {
            this.buildInLamp = buildInLamp;
            this.numberOfShelves = numberOfShelves;
        }

        public bool HasBuildInLamp()
        {
            return this.buildInLamp;
        }

        public override string ToString()
        {
            
            return "WARDROBE # " + base.ToString() + " | Shelves: " + this.numberOfShelves + (this.buildInLamp ? " | Built-in-lamp" : "");
        }

    }
}