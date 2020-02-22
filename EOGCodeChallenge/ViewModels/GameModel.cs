namespace EOGCodeChallenge.ViewModels
{
    class GameModel : ViewModelBase
    {
        private int _numberOfPlayers;
        private int _numberOfGamesToSimulate;
        private int _shortestGame;
        private int _longestGame;
        private int _averageGame;

        public GameModel()
        {

        }

        public int NumberOfPlayers
        {
            get => _numberOfPlayers;
            set => SetProperty(ref _numberOfPlayers, value);
        }

        public int NumberOfGamesToSimulate
        {
            get => _numberOfGamesToSimulate;
            set => SetProperty(ref _numberOfGamesToSimulate, value);
        }

        public int ShortestLengthGame
        {
            get => _shortestGame;
            set => SetProperty(ref _shortestGame, value);
        }

        public int LongestLengthGame
        {
            get => _longestGame;
            set => SetProperty(ref _longestGame, value);
        }

        public int AverageLengthGame
        {
            get => _averageGame;
            set => SetProperty(ref _averageGame, value);
        }

        public void ExecuteSimulation()
        {

        }
    }
}
