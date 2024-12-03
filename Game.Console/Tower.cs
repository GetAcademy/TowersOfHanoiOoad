namespace Game.UI
{
    internal class Tower
    {
        private readonly Disc[] _discs;
        private readonly int _position;

        public Tower(int position, params int[] discSizes)
        {
            _discs = new Disc[3];
            for (var index = 0; index < discSizes.Length; index++)
            {
                var size = discSizes[index];
                _discs[index] = new Disc(size);
            }
            _position = position;
        }

        public Disc GetTopDisc()
        {
            return _discs[0];
        }

        public Disc RemoveTopDisc()
        {
            var disc = _discs[0];
            _discs[0] = _discs[1];
            _discs[1] = _discs[2];
            _discs[2] = null;
            return disc;
        }

        public void ReceiveDisc(Disc disc)
        {
            _discs[2] = _discs[1];
            _discs[1] = _discs[0];
            _discs[0] = disc;
        }

        public void Show()
        {
            var row = 4;
            foreach (var disc in _discs.Reverse())
            {
                disc?.Show(row, _position);
                row--;
            }
            MyConsole.Write(5, 2 + (_position - 1) * 15, "OOOOOOOOO");
        }
    }
}
