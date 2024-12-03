namespace Game.UI
{
    internal class Tower
    {
        private Disc[] _discs;
        private int _position;

        public Tower(int position, Disc[] discs)
        {
            _discs = discs;
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
