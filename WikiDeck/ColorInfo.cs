using System.Drawing;

namespace WikiDeck
{
    public class ColorInfo
    {
        public Color Color { get; private set; }
        public string Name { get; private set; }

        public ColorInfo(Color color, string name)
        {
            Color = color;
            Name = name;
        }
    }
}
