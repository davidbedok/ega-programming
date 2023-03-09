using System.Collections.Generic;

namespace SwedishStore
{
    public class Furniture : Selable
    {
        private readonly string name;
        private int price;

        private Room room;
        private Dimension dimension;

        public Furniture(string name, int price, Room room, Dimension dimension)
        {
            this.name = name;
            this.price = price;
            this.room = room;
            this.dimension = dimension;
        }

        public Room GetRoom()
        {
            return this.room;
        }

        public Dimension GetDimension()
        {
            return this.dimension;
        }

        public string Buy()
        {
            return this.ToString(); // FIXME
        }

        public string GetFriendlyName()
        {
            return this.name;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public override string ToString()
        {
            return this.name +":" + this.room + " (" + this.price + " EUR, " + this.dimension + ")";
        }

        public bool IsMatch(Room room, int minWidth, int maxWidth, int minHeight, int maxHeight)
        {
            return room == this.room && this.dimension.IsMatch(minWidth, maxWidth, minHeight, maxHeight);
        }

        public bool IsMatch(Room room, bool collapsable)
        {
            bool result = false;
            if (this is Collapsable)
            {
                result = room == this.room && (this as Collapsable).IsCollapsable() == collapsable;
            } else
            {
                result = room == this.room && !collapsable;
            }
            return result;
        }

    }
}