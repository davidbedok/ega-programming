namespace SwedishStore
{
    public interface Selable
    {

        public abstract string GetFriendlyName();

        public abstract int GetPrice();

        public abstract string Buy();

        public abstract bool IsMatch(Room room, int minWidth, int maxWidth, int minHeight, int maxHeight);

        public abstract bool IsMatch(Room room, bool collapsable);


    }


}