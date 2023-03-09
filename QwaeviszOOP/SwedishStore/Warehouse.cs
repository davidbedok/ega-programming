using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace SwedishStore
{
    public class Warehouse
    {

        private List<Selable> selables;

        public Warehouse()
        {
            this.selables = new List<Selable>();

        }

        public void Add(Selable selable)
        {
            this.selables.Add(selable);
        }

        public override string ToString()
        {
            StringBuilder content = new StringBuilder(100);
            content.AppendLine("=== WAREHOUSE ===");
            foreach ( Selable item in this.selables )
            {
                content.AppendLine(item.ToString());
            }
            return content.ToString();
        }

        public List<Selable> Find(Room room, int minWidth, int maxWidth, int minHeight, int maxHeight)
        {
            Console.WriteLine("<Find> " + room + " and " + minWidth + " < W < " + maxWidth + " and " + minHeight + " < H < " + maxHeight);
            List<Selable> result = new List<Selable>();
            for ( int i = 0; i < this.selables.Count; i++ )
            {
                Selable item = this.selables.ElementAt(i);
                if ( item.IsMatch(room, minWidth, maxWidth, minHeight, maxHeight) )
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<Selable> Find(Room room, bool collapsable)
        {
            Console.WriteLine("<Find> " + room + " and " + ( collapsable ? "Collapsable" : "Non-collapsable" ) );
            List<Selable> result = new List<Selable>();
            for (int i = 0; i < this.selables.Count; i++)
            {
                Selable item = this.selables[i];
                if (item.IsMatch(room, collapsable))
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }
}