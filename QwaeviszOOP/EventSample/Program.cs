using System;

namespace EventSample
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Market market = new Market();
            
            market.AddGadget(new Gadget("iPhone 5 SE", 100));
            market.AddGadget(new Gadget("Nintendo NES Mini", 200));
            market.AddGadget(new Gadget("Nintendo SNES Mini", 240));
            market.AddGadget(new Gadget("Sony PlayStation 4 Pro", 300));

            Console.WriteLine(market.Buy("Nintendo NES Mini", "David"));
            Console.WriteLine(market.Buy("Sony PlayStation 4 Pro", "Hunor"));



        }
    }
}
