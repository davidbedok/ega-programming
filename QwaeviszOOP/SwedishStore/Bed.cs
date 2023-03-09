namespace SwedishStore
{
    public class Bed : Furniture, Collapsable, BuildInLampCapable
    {
        private BedSize size;

        private bool collapsable;
        private bool buildInLamp;

        public BedSize Size
        {
            get { return this.size; }
        }

        public Bed(string name, int price, Room room, Dimension dimension, bool collapsable, bool buildInLamp, BedSize size) : base(name, price, room, dimension)
        {
            this.collapsable = collapsable;
            this.buildInLamp = buildInLamp;
            this.size = size;
        }

        public BedSize GetBedSize()
        {
            return this.size;
        }

        public bool HasBuildInLamp()
        {
            return this.buildInLamp;
        }

        public bool IsCollapsable()
        {
            return this.collapsable;
        }

        public override string ToString()
        {
            return "BED # " + base.ToString() + " | Size: " + this.size + (this.collapsable ? " | Collapsable" : "" ) + (this.buildInLamp ? " | Built-in-lamp" : "");
        }

    }
}