namespace SwedishStore
{
    internal class Table : Furniture, Collapsable
    {
        private int numberOfChairs;
        private bool collapsable;

        public int NumberOfChairs
        {
            get { return this.numberOfChairs; }
        }

        public Table(string name, int price, Room room, Dimension dimension, bool collapsable, int numberOfChairs) : base(name, price, room, dimension)
        {
            this.collapsable = collapsable;
            this.numberOfChairs = numberOfChairs;
        }

        public bool IsCollapsable()
        {
            return this.collapsable;
        }

        public override string ToString()
        {
            return "TABLE # " + base.ToString() + " | Chairs: " + this.numberOfChairs + (this.collapsable ? " | Collapsable" : "");
        }

    }
}