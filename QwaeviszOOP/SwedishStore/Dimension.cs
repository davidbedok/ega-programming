namespace SwedishStore
{
    public class Dimension
    {
        private int length;
        private int width;
        private int height;

        public int Length { get { return length; } }
        public int Width { get { return width; } }
        public int Height { get { return height; } }

        public Dimension(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return this.width + "x" + this.height + "x" + this.length;
        }

        public bool IsMatch(int minWidth, int maxWidth, int minHeight, int maxHeight)
        {
            return this.width >= minWidth && this.width <= maxWidth && this.height >= minHeight && this.height <= maxHeight;
        }

    }
}