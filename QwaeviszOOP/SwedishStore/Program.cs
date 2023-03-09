using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata;

namespace SwedishStore
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Demo d = new Demo();

            // d.length = 45;
            // d.SetLength(140);
            // Console.WriteLine(d.GetLength());

            d.Length = -140;
            d.Height = -120;
            Console.WriteLine(d.Length);
            Console.WriteLine(d.Height);


            Warehouse wh = new Warehouse();

            wh.Add(new Table("Ldbeugfe", 177, Room.Kitchen, new Dimension(50, 80, 50), false, 4));
            wh.Add(new Wardrobe("Egrhtr", 125, Room.Livingroom, new Dimension(60, 230, 150), false, 3));
            wh.Add(new Bed("Anjfeg", 100, Room.Bedroom, new Dimension(70, 180, 50), true, false, BedSize.Double));
            wh.Add(new Table("Ofbejgr", 256, Room.Livingroom, new Dimension(80, 120, 120), true, 2));
            wh.Add(new Wardrobe("Dmnkgrgr", 60, Room.Kitchen, new Dimension(90, 50, 80), true, 6));
            wh.Add(new Bed("Bcehrgur", 150, Room.Livingroom, new Dimension(100, 180, 50), true, true, BedSize.King));
            wh.Add(new Table("Hfnerkgr", 123, Room.Bedroom, new Dimension(110, 85, 90), true, 4));
            wh.Add(new Bed("Cgrnjigr", 170, Room.Bedroom, new Dimension(120, 180, 50), false, true, BedSize.Single));
            wh.Add(new Table("Kvehgr", 256, Room.Livingroom, new Dimension(130, 80, 110), true, 2));
            wh.Add(new Wardrobe("Fhtjrew", 205, Room.Livingroom, new Dimension(140, 230, 100), true, 6));
            wh.Add(new Table("Ivbjrgr", 130, Room.Kitchen, new Dimension(150, 150, 90), false, 6));
            wh.Add(new Wardrobe("Gjzthrefde", 115, Room.Hall, new Dimension(160, 230, 100), false, 2));
            wh.Add(new Table("Jcebjgrt", 45, Room.Kitchen, new Dimension(170, 90, 90), true, 0));

            Console.WriteLine(wh);

            List<Selable> result = wh.Find(Room.Livingroom, 50, 150, 40, 200);
            foreach (Selable item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            foreach (Selable item in wh.Find(Room.Kitchen, true))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            foreach (Selable item in wh.Find(Room.Kitchen, false))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

        }

    }
}
