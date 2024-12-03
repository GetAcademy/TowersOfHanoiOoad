namespace Game.UI
{
    internal class Disc
    {
        private readonly int _size;

        public Disc(int size)
        {
            _size = size;
        }

        public void Show(int row, int columnNo)
        {
            var col = 1 + (columnNo - 1) * 15;
            var text = "".PadLeft(_size, '#');
            MyConsole.WriteCentered(row, col, 11, text);
        }
    }
}
