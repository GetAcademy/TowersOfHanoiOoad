namespace Game.UI
{
    internal class Game
    {
        private readonly Tower[] _towers;

        public Game()
        {
            _towers = new Tower[]
            {
                new Tower(1, 3, 5, 7),
                new Tower(2),
                new Tower(3)
            };
        }

        public void Run()
        {
            while (!IsSolved())
            {
                Show();
                var fromIndex = MyConsole.AskForNoAndReturnIndex(7, "Flytte disc fra tårn: ");
                var toIndex = MyConsole.AskForNoAndReturnIndex(8, "Flytte disc til tårn: ");
                MoveDisc(fromIndex, toIndex);
            }
        }

        private void MoveDisc(int fromIndex, int toIndex)
        {
            var fromTower = _towers[fromIndex];
            var disc = fromTower.RemoveTopDisc();
            var toTower = _towers[toIndex];
            toTower.ReceiveDisc(disc);
        }

        public bool IsSolved()
        {
            return false;
        }

        public void Show()
        {
            Console.Clear();
            foreach (var tower in _towers)
            {
                tower.Show();
            }
        }
    }
}
